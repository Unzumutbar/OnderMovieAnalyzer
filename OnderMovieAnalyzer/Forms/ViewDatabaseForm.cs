using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class ViewDatabaseForm : Form
    {
        private SortableBindingList<Movie> MovieBindingList = new SortableBindingList<Movie>();
        private ImportMoviesForm ImportMoviesForm;

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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ImportMoviesForm == null || (ImportMoviesForm.IsDisposed))
                {
                    ImportMoviesForm = new ImportMoviesForm() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
                }
                ImportMoviesForm.FilesToRead = openFileDialog.FileNames;
                ImportMoviesForm.Show(this);
                ImportMoviesForm.StartImport();
            }
        }
    }
}
