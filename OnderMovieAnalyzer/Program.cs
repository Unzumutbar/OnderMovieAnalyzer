using OnderMovieAnalyzer.Forms;
using OnderMovieAnalyzer.Helper;
using OnderMovieAnalyzer.Objects;
using System;
using System.IO;
using System.Windows.Forms;

namespace OnderMovieAnalyzer
{
    static class Program
    {
        public static string AppDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string DatabaseXmlFile = "OnderMovieCollection.xml";
        public static MovieList Movies;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DatabaseXmlFile))
                XmlHelper.WriteEmptyDatabase();

            Movies = new MovieList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
