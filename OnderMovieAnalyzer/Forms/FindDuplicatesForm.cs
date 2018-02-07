using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class FindDuplicatesForm : Form
    {
        public SortableBindingList<Movie> Duplicates = new SortableBindingList<Movie>();
        private FindDuplicatesDialog _findDuplicatesDialog;
        private ExportDuplicatesDialog _exportDuplicatesDialog;

        public FindDuplicatesForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenFindDuplicatesDialog();
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            var selectedMovies = new List<Movie>();
            var selectRowsCount = dataGridDuplicates.SelectedRows.Count;
            for (int i = 0; i < selectRowsCount; i++)
            {
                var obj = dataGridDuplicates.SelectedRows[i].DataBoundItem as Movie;
                if (obj != null)
                    selectedMovies.Add(obj);
            }
            if (!selectedMovies.Any())
                return;

            var wrongMovies = new List<Movie>();
            foreach (var movie in selectedMovies)
            {
                if (movie.Location == System.Environment.MachineName)
                    Program.Movies.DeleteMovie(movie);

                else
                    wrongMovies.Add(movie);
            }

            string couldNotDelete = ".";
            if (wrongMovies.Any())
            {
                couldNotDelete = String.Format(" with some Errors. {0} Could not delete {1} movies. Reason: Wrong location", Environment.NewLine, wrongMovies.Count());
                foreach (var movie in wrongMovies)
                    couldNotDelete += string.Format("{0}{1}", Environment.NewLine, movie.FullPath);
            }
            MessageBox.Show(string.Format("Deletion completed{0}", couldNotDelete), "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFindDuplicatesDialog();
        }

        public void OpenFindDuplicatesDialog()
        {
            var movieList = Program.Movies.GetMovieList();
            var filter = GetFilter();
            if (_findDuplicatesDialog == null || (_findDuplicatesDialog.IsDisposed))
            {
                _findDuplicatesDialog = new FindDuplicatesDialog(movieList) { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            _findDuplicatesDialog.Show(this);
            _findDuplicatesDialog.StartDuplicateSearch(filter);
        }

        private DuplicateFilter GetFilter()
        {
            var filter = new DuplicateFilter();
            filter.Name = radioButtonName.Checked;
            filter.Quality = checkBoxQuality.Checked;
            filter.Part = checkBoxPart.Checked;
            filter.Language = checkBoxLanguage.Checked;
            filter.Year = checkBoxYear.Checked;
            filter.Episode = checkBoxEpisode.Checked;
            filter.Filesize = checkBoxFilesize.Checked;           
            filter.DLDistance = radioButtonDLDistance.Checked;
            filter.NumericUpDownDistance = (int)numericUpDownDistance.Value;
            return filter;
        }

        public void RefreshList(List<Movie> duplicateList)
        {
            Duplicates = new SortableBindingList<Movie>(duplicateList);
            var source = new BindingSource(Duplicates, null);
            dataGridDuplicates.DataSource = source;
            if (Duplicates.Any())
                this.buttonSave.Enabled = true;
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEpisode.Enabled = radioButtonName.Checked;
            checkBoxPart.Enabled = radioButtonName.Checked;
        }

        private void itemRemoveFromList_Click(object sender, EventArgs e)
        {
            var selectedMovies = new List<Movie>();
            var selectRowsCount = dataGridDuplicates.SelectedRows.Count;
            for (int i = 0; i < selectRowsCount; i++)
            {
                var obj = dataGridDuplicates.SelectedRows[i].DataBoundItem as Movie;
                if (obj != null)
                    selectedMovies.Add(obj);
            }
            if (!selectedMovies.Any())
                return;

            foreach (var movie in selectedMovies)
                Duplicates.Remove(movie);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    FileHelper.SaveDuplicatesToFile(Duplicates.ToList(), saveFileDialog.FileName);
            //}
            OpenExportDuplicatesDialog();
        }

        public void OpenExportDuplicatesDialog()
        {
            if (_exportDuplicatesDialog == null || (_exportDuplicatesDialog.IsDisposed))
            {
                var movieList = Program.Movies.GetMovieList();
                _exportDuplicatesDialog = new ExportDuplicatesDialog(movieList, Duplicates.ToList()) { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            _exportDuplicatesDialog.Show(this);
        }
    }
}
