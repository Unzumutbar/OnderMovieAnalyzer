using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnderMovieAnalyzer.Forms
{
    public partial class ImportMoviesForm : Form
    {
        public string[] FilesToRead;
        public List<Movie> ImportedMovies;
        private string _currentFile;
        private int _currentFileNumber;
        private int _totalFileNumber;
        private int _currentLineNumber;
        private int moviesCount;
        private enum ReportType
        {
            NewFile,
            NewLine,
        }

        public ImportMoviesForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public void StartImport()
        {
            progressBarInstall.Value = 0;
            _currentFileNumber = 1;
            _totalFileNumber = FilesToRead.Length;
            moviesCount = Program.Movies.GetMovieList().Count;
            backgroundWorkerInstall.RunWorkerAsync();
        }

        private void backgroundWorkerInstall_DoWork(object sender, DoWorkEventArgs e)
        {
            var movieList = new List<Movie>();
            foreach (var txtFile in FilesToRead)
            {
                if (File.Exists(txtFile) && txtFile.Contains(".txt"))
                {
                    var fileName = Path.GetFileNameWithoutExtension(txtFile);
                    _currentFile = fileName;
                    var Encoding = EncodingDetector.DetectTextFileEncoding(txtFile);
                    //moviesString += File.ReadAllText(txtFile);
                    var myFile = new StreamReader(txtFile, Encoding);
                    var moviesString = myFile.ReadToEnd();
                    myFile.Close();
      
                    moviesString = moviesString.Replace("last-modified   |ext |size|name|location", string.Empty);
                    var moviesLines = moviesString.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    backgroundWorkerInstall.ReportProgress(moviesLines.Count(), ReportType.NewFile);
                    foreach (var line in moviesLines)
                    {
                        if (line != "done" && !string.IsNullOrWhiteSpace(line))
                        {
                            var movie = FileHelper.GetMovieFromLine(line, fileName);
                            if (movie != null)
                            {
                                movieList.Add(movie);
                                Program.Movies.AddMovieToList(movie);
                            }
                        }
                        backgroundWorkerInstall.ReportProgress(0, ReportType.NewLine);
                    }
                }
            }
            ImportedMovies = movieList;
        }

        private void backgroundWorkerInstall_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var reportType = (ReportType)e.UserState;
            switch (reportType)
            {
                case ReportType.NewFile:
                    this.labelCurrentStep.Text = string.Format("{0} ({1} / {2})", _currentFile, _currentFileNumber, _totalFileNumber);
                    progressBarInstall.Value = 0;
                    progressBarInstall.Maximum = e.ProgressPercentage;
                    _currentFileNumber++;
                    _currentLineNumber = 1;
                    break;
                case ReportType.NewLine:
                    if (progressBarInstall.Value < progressBarInstall.Maximum)
                        progressBarInstall.Value++;                    
                    this.labelCurrentLine.Text = string.Format("Reading line {0} / {1}", _currentLineNumber, progressBarInstall.Maximum);
                    _currentLineNumber++;
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorkerInstall_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarInstall.Value = progressBarInstall.Maximum;
            moviesCount = Program.Movies.GetMovieList().Count - moviesCount;

            var parent = ((ViewDatabaseForm)Owner);
            if (parent != null && !parent.IsDisposed)
                parent.RefreshList();

            MessageBox.Show(string.Format("{0} new Movies have been added to the Database", moviesCount), "Analysis Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
