using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class ViewDatabaseForm : Form
    {
        private SortableBindingList<Movie> MovieBindingList = new SortableBindingList<Movie>();

        public ViewDatabaseForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ViewDatabaseForm_Shown(object sender, EventArgs e)
        {
            RefreshList();
        }

        public void RefreshList()
        {
            var movieList = Program.Movies.GetMovieList();
            var MovieBindingList = new SortableBindingList<Movie>(movieList);
            var source = new BindingSource(MovieBindingList, null);
            dataGridView1.DataSource = source;
        }

        private void buttonDeleteDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the database?", "Confirm Database deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
                return;

            FileHelper.DeleteFile(Program.DatabaseXmlFile);
            XmlHelper.WriteEmptyDatabase();
            Program.Movies = new MovieList();
            RefreshList();
        }

        private void buttonAddMoviesFromTxt_Click(object sender, EventArgs e)
        {
            int newMoviesCount = Program.Movies.GetMovieList().Count;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var newMovies = FileHelper.GetMovieListFromTexts(openFileDialog.FileNames);
                foreach (var newMovie in newMovies)
                    Program.Movies.AddMovieToList(newMovie);

                newMoviesCount = Program.Movies.GetMovieList().Count - newMoviesCount;
                MessageBox.Show(string.Format("{0} new Movies have been added to the Database", newMoviesCount), "Analysis Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
            }
        }
    }
}
