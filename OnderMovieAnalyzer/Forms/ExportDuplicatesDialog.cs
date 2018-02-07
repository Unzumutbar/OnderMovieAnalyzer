using OnderMovieAnalyzer.Extensions;
using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class ExportDuplicatesDialog : Form
    {
        private List<Movie> _movieList;
        private List<Movie> _duplicatesList;

        public ExportDuplicatesDialog(List<Movie> movieList, List<Movie> duplicatesList)
        {
            _movieList = movieList;
            _duplicatesList = duplicatesList;

            InitializeComponent();
            comboBoxPriority.Items.AddRange(GetFileLocations(movieList));
            comboBoxPriority.SelectedIndex = 0;
        }

        private string[] GetFileLocations(List<Movie> movieList)
        {
            return movieList.DistinctBy(m => m.Location).Select(m=> m.Location).OrderBy(l => l).ToArray();
        }        

        private void buttonExport_Click(object sender, System.EventArgs e)
        {
            ExportOptions exportOptions = GetExportOptions();
            var exportLines = GetExportCommandList(_movieList, _duplicatesList, exportOptions);
            if (exportLines.Any())
            {
                if (exportOptions.ExportType == ExportType.CopyScripts)
                    saveFileDialog.FileName = "OnderMovieCopyScript";
                else if (exportOptions.ExportType == ExportType.DeletScripts)
                    saveFileDialog.FileName = "OnderMovieDeleteScript";
                else if (exportOptions.ExportType == ExportType.Text)
                    saveFileDialog.FileName = "OnderMovieDuplicateDump";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    FileHelper.SaveToFile(exportLines.ToArray(), saveFileDialog.FileName);
            }
        }

        private ExportOptions GetExportOptions()
        {
            var options = new ExportOptions();
            options.FileSource = comboBoxPriority.SelectedText;
            options.ExportType = radioCopyScript.Checked ? ExportType.CopyScripts : ExportType.DeletScripts;
            return options;
        }

        private IEnumerable<string> GetExportCommandList(List<Movie> movieList, List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            switch (exportOptions.ExportType)
            {
                case ExportType.CopyScripts:
                    return GetCopyScript(movieList, duplicatesList, exportOptions);
                case ExportType.DeletScripts:
                    return GetDeleteScript(duplicatesList, exportOptions);
                default: return new string[0].AsEnumerable();
            }
        }

        private IEnumerable<string> GetDeleteScript(List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            var moviesToDelete = GetMoviesForDeleteScript(duplicatesList, exportOptions);
            var lastLocation = string.Empty;
            foreach (var movie in moviesToDelete.OrderBy(mov => mov.Location))
            {
                var line = string.Empty;
                if (!lastLocation.Equals(movie.Location))
                {
                    lastLocation = movie.Location;
                    line += string.Format("{1}{1}# {0}{1}", movie.Location, Environment.NewLine);
                }

                line += string.Format("rm {0}{1}", movie.Path, Environment.NewLine);
                yield return line;
            }
        }

        private IEnumerable<Movie> GetMoviesForDeleteScript(List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            var moviesToDelete = duplicatesList.Except(GetMoviesToKeep(duplicatesList, exportOptions));
            return moviesToDelete;
        }

        private IEnumerable<string> GetCopyScript(List<Movie> movieList, List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            var moviesToCopy = GetMoviesForCopyScript(movieList, duplicatesList, exportOptions);
            var lastLocation = string.Empty;
            foreach (var movie in moviesToCopy.OrderBy(mov => mov.Location))
            {
                var line = string.Empty;
                if (!lastLocation.Equals(movie.Location))
                {
                    lastLocation = movie.Location;
                    line += string.Format("{1}{1}# {0}{1}", movie.Location, Environment.NewLine);
                }

                var year = movie.Year;
                if (string.IsNullOrEmpty(year))
                    year = "1900";

                year = year.Substring(0, 3) + "0";
                line = string.Format(@"cp {0} DISK://{1}{2}", movie.Path, year, Environment.NewLine);
                yield return line;
            }
        }

        private IEnumerable<Movie> GetMoviesForCopyScript(List<Movie> movieList, List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            var moviesToKeep = movieList.Except(duplicatesList).ToList();
            moviesToKeep.AddRange(GetMoviesToKeep(duplicatesList, exportOptions));
            return moviesToKeep;
        }

        private IEnumerable<Movie> GetMoviesToKeep(List<Movie> duplicatesList, ExportOptions exportOptions)
        {
            foreach (var duplicateId in duplicatesList.DistinctBy(mov => mov.DuplicateId).Select(mov => mov.DuplicateId))
            {
                var duplicates = duplicatesList.Where(mov => mov.DuplicateId == duplicateId);
                var bestQuality = duplicates.OrderByDescending(mov => mov.QualityEnum).FirstOrDefault().QualityEnum;
                var duplicatesToKeep = duplicates.Where(mov => mov.QualityEnum == bestQuality);
                var movieToKeep = duplicatesToKeep.FirstOrDefault();
                if (duplicatesToKeep.Any(mov => mov.Location == exportOptions.FileSource))
                    movieToKeep = duplicatesToKeep.FirstOrDefault(mov => mov.Location == exportOptions.FileSource);

                yield return movieToKeep;
            }
        }
    }
}
