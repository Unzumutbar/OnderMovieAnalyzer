using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class MainForm : Form
    {
        private FindDuplicatesForm FindDuplicatesForm;
        private ViewDatabaseForm ViewDatabaseForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public List<Movie> Movies
        {
            get { return Program.Movies.GetMovieList(); }
        }

        private void buttonSearchDirectory_Click(object sender, System.EventArgs e)
        {
            int newMoviesCount = Program.Movies.GetMovieList().Count;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var newMovies = FileHelper.GetMovieListFromFiles(folderBrowserDialog.SelectedPath);
                foreach (var newMovie in newMovies)
                    Program.Movies.AddMovieToList(newMovie);

                newMoviesCount = Program.Movies.GetMovieList().Count - newMoviesCount;
                MessageBox.Show(string.Format("{0} new Movies have been added to the Database", newMoviesCount), "Analysis Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (FindDuplicatesForm != null && !FindDuplicatesForm.IsDisposed)
                    FindDuplicatesForm.RefreshList();

                if (ViewDatabaseForm != null && !ViewDatabaseForm.IsDisposed)
                    ViewDatabaseForm.RefreshList();
            }
        }

        private void buttonGetDuplicates_Click(object sender, System.EventArgs e)
        {
            if (FindDuplicatesForm == null || (FindDuplicatesForm.IsDisposed))
                FindDuplicatesForm = new FindDuplicatesForm() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };

            FindDuplicatesForm.Show();
        }

        private void buttonViewDatabase_Click(object sender, System.EventArgs e)
        {
            if (ViewDatabaseForm == null || (ViewDatabaseForm.IsDisposed))
                ViewDatabaseForm = new ViewDatabaseForm() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };

            ViewDatabaseForm.Show();
        }
    }
}
