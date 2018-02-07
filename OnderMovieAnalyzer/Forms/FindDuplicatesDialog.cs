using OnderMovieAnalyzer.Extensions;
using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class FindDuplicatesDialog : Form
    {
        private List<Movie> _movieList;
        private List<Movie> _duplicatesList;
        private DuplicateFilter _filter;
        private int _currentMovieNumber;
        private int _moviesCount;

        public FindDuplicatesDialog(List<Movie> movieList)
        {
            _movieList = movieList;
            _moviesCount = _movieList.Count;
            _currentMovieNumber = 1;
            InitializeComponent();
            this.ControlBox = false;
        }

        public void StartDuplicateSearch(DuplicateFilter filter)
        {
            progressBarInstall.Value = 0;
            progressBarInstall.Maximum = _moviesCount;
            _filter = filter;
            backgroundWorkerInstall.RunWorkerAsync();
        }

        private void backgroundWorkerInstall_DoWork(object sender, DoWorkEventArgs e)
        {
            _duplicatesList = FindDuplicates(_movieList).ToList();
        }

        private IEnumerable<Movie> FindDuplicates(List<Movie> movieList)
        {
            var duplicateList = new List<Movie>();
            int duplicateId = 1;
            foreach (var movie in movieList)
            {
                IEnumerable<Movie> foundDuplicates = movieList.AsEnumerable();
                if (!duplicateList.Any(m => m.Guid == movie.Guid))
                {
                    if (_filter.Name)
                        foundDuplicates = foundDuplicates.Where(m => m.Name == movie.Name && m.Guid != movie.Guid);

                    if (_filter.Name && _filter.Part)
                        foundDuplicates = foundDuplicates.Where(m => m.Name == movie.Name && m.Guid != movie.Guid && movie.Part == m.Part);

                    if (_filter.Name && _filter.Episode)
                        foundDuplicates = foundDuplicates.Where(m => m.Name == movie.Name && m.Guid != movie.Guid && movie.Episode == m.Episode);

                    if (_filter.Language)
                        foundDuplicates = foundDuplicates.Where(m => m.LanguageDub == movie.LanguageDub && m.Guid != movie.Guid);

                    if (_filter.Year)
                        foundDuplicates = foundDuplicates.Where(m => m.Year == movie.Year && m.Guid != movie.Guid);

                    if (_filter.Filesize)
                        foundDuplicates = foundDuplicates.Where(m => m.Size == movie.Size && m.Guid != movie.Guid);

                    if (_filter.Quality)
                        foundDuplicates = foundDuplicates.Where(m => m.Quality == movie.Quality && m.Guid != movie.Guid);

                    if (_filter.DLDistance)
                    {
                        var distanceList = new List<Movie>();
                        foreach (var film in foundDuplicates)
                        {
                            if (film.Guid != movie.Guid)
                            {
                                int distance = film.Name.DamerauLevenshteinDistanceTo(movie.Name);
                                if (distance <= _filter.NumericUpDownDistance)
                                    distanceList.Add(film);
                            }
                        }
                        foundDuplicates = distanceList.AsEnumerable<Movie>();
                    }

                    if (foundDuplicates.Any())
                    {
                        movie.DuplicateId = duplicateId;
                        duplicateList.Add(movie);
                        foreach (var duplicate in foundDuplicates)
                        {
                            duplicate.DuplicateId = duplicateId;
                            duplicateList.Add(duplicate);
                        }
                        duplicateId++;
                    }
                }
                backgroundWorkerInstall.ReportProgress(0, null);
            }
            return duplicateList;
        }

        private void backgroundWorkerInstall_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBarInstall.Value < progressBarInstall.Maximum)
                progressBarInstall.Value++;
            this.labelCurrentStep.Text = string.Format("Reading movie {0} / {1}", _currentMovieNumber, progressBarInstall.Maximum);
            _currentMovieNumber++;
        }

        private void backgroundWorkerInstall_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarInstall.Value = progressBarInstall.Maximum;
            var duplicatesCount = _duplicatesList.Count();

            var parent = ((FindDuplicatesForm)Owner);
            if (parent != null && !parent.IsDisposed)
                parent.RefreshList(_duplicatesList);

            MessageBox.Show(string.Format("{0} duplicates have been found", duplicatesCount), "Search Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
