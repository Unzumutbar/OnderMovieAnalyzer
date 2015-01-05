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

        private void RefreshList()
        {
            var movieList = Program.Movies.GetMovieList();
            var MovieBindingList = new SortableBindingList<Movie>(movieList);
            var source = new BindingSource(MovieBindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
