using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class FindDuplicatesForm : Form
    {
        public SortableBindingList<Movie> Duplicates = new SortableBindingList<Movie>();

        public FindDuplicatesForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshList();
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
            RefreshList();
        }

        public void RefreshList()
        {
            var duplicateList = new List<Movie>();
            var movieList = Program.Movies.GetMovieList();
            this.buttonSave.Enabled = false;

            foreach (var movie in movieList)
            {
                IEnumerable<Movie> foundDuplicates = movieList.AsEnumerable();
                if (!duplicateList.Any(m => m.Guid == movie.Guid))
                {
                    if (this.radioButtonName.Checked)
                        foundDuplicates = foundDuplicates.Where(m => m.Name == movie.Name && m.Guid != movie.Guid);

                    if (this.checkBoxLanguage.Checked)
                        foundDuplicates = foundDuplicates.Where(m => m.LanguageDub == movie.LanguageDub && m.Guid != movie.Guid);

                    if (this.checkBoxYear.Checked)
                        foundDuplicates = foundDuplicates.Where(m => m.Year == movie.Year && m.Guid != movie.Guid);

                    if (this.checkBoxFilesize.Checked)
                        foundDuplicates = foundDuplicates.Where(m => m.Size == movie.Size && m.Guid != movie.Guid);

                    if (this.checkBoxQuality.Checked)
                        foundDuplicates = foundDuplicates.Where(m => m.Quality == movie.Quality && m.Guid != movie.Guid);

                    if (this.radioButtonDLDistance.Checked)
                    {
                        var distanceList = new List<Movie>();
                        foreach (var film in foundDuplicates)
                        {
                            if (film.Guid != movie.Guid)
                            {
                                int distance = film.Name.DamerauLevenshteinDistanceTo(movie.Name);
                                if (distance <= numericUpDownDistance.Value)
                                    distanceList.Add(film);
                            }
                        }
                        foundDuplicates = distanceList.AsEnumerable<Movie>();
                    }

                    if (foundDuplicates.Any())
                    {
                        duplicateList.Add(movie);
                        duplicateList.AddRange(foundDuplicates.ToList());
                    }
                }
            }

            Duplicates = new SortableBindingList<Movie>(duplicateList);
            var source = new BindingSource(Duplicates, null);
            dataGridDuplicates.DataSource = source;
            if (Duplicates.Any())
                this.buttonSave.Enabled = true;
        }
    }
}
