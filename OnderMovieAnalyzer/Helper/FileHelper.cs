using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace OnderMovieAnalyzer.Helper
{
    public static class FileHelper
    {
        public static List<Movie> GetMovieListFromFiles(string directory)
        {
            var movieList = new List<Movie>();
            var files = Directory.GetFiles(directory);
            foreach (var movie in files)
            {
                if (IsVideoFile(movie))
                {
                    var newMovie = GetMovieFromFile(movie);
                    movieList.Add(newMovie);
                }
            }
            return movieList;
        }

        private static string[] mediaExtensions = {
                "MP2", "MP2V",".MP4", "MP4V", 
                ".AVI", ".DIVX", ".WMV", "MKV", 
                "MPA", "MPE", "MPEG", "MOV"
            };

        private static bool IsVideoFile(string path)
        {
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        public static Movie GetMovieFromFile(string fileToConvert)
        {
            var newMovie = new Movie();
            var fileName = Path.GetFileNameWithoutExtension(fileToConvert);

            var movieName = GetName(fileName);
            var movieDetails = GetDetails(fileName);

            newMovie.Guid = Guid.NewGuid().ToString();

            newMovie.Name = movieName;
            newMovie.LanguageOriginal = ReadLanguageOriginal(movieDetails);
            newMovie.LanguageDub = ReadLanguageDub(movieDetails);
            if (string.IsNullOrWhiteSpace(newMovie.LanguageDub))
                newMovie.LanguageDub = newMovie.LanguageOriginal;

            newMovie.Quality = ReadQuality(movieDetails);
            newMovie.Source = ReadSource(movieDetails);
            newMovie.TvStation = ReadTvStation(movieDetails);
            newMovie.Year = ReadYear(movieDetails);

            newMovie.Location = System.Environment.MachineName;
            newMovie.Path = fileToConvert;
            newMovie.Size = new FileInfo(fileToConvert).Length;
            newMovie.LastModified = new FileInfo(fileToConvert).LastWriteTime;

            return newMovie;
        }

        private static string ReadTvStation(string details)
        {
            var fullSource = GetTagContent(details, "src");
            if (string.IsNullOrWhiteSpace(fullSource))
                return string.Empty;

            var tokens = fullSource.Split(new char[] { '!' });
            if (tokens.Length < 2)
                return string.Empty;

            return tokens[1].Replace(",", "");
        }

        private static string ReadYear(string details)
        {
            string dateAsString = GetTagContent(details, "date");
            if (dateAsString != string.Empty)
            {
                DateTime dateAsDateTime;
                if (DateTime.TryParse(dateAsString, out dateAsDateTime))
                    return dateAsDateTime.Year.ToString();
            }

            return GetTagContent(details, "year");

        }

        private static string ReadSource(string details)
        {
            var fullSource = GetTagContent(details, "src");
            if (string.IsNullOrWhiteSpace(fullSource))
                return string.Empty;

            var tokens = fullSource.Split(new char[] { '!' });
            if (tokens.Length < 1)
                return string.Empty;

            return tokens[0];
        }

        private static string ReadQuality(string details)
        {
            return GetTagContent(details, "res");
        }

        private static string ReadLanguageDub(string details)
        {
            return GetTagContent(details, "lang");
        }

        private static string ReadLanguageOriginal(string details)
        {
            return GetTagContent(details, "olang");
        }

        public static bool DeleteMovie(Movie movieToDelete)
        {
            try
            {

                Thread thread = new Thread(delegate() { DeleteFile(movieToDelete.Path); });
                thread.Start();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void DeleteFile(string fileStringToDelete)
        {
            FileInfo fileToDelete = new FileInfo(fileStringToDelete);
            if (fileToDelete.Exists)
            {
                while (IsFileLocked(fileToDelete))
                    Thread.Sleep(1000);
                fileToDelete.Delete();
            }
        }

        public static bool MovieExists(Movie movieToCheck)
        {
            return false;
        }

        private static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        private static string GetDetails(string s)
        {
            if (!s.Contains("["))
                return string.Empty;

            var startTag = "[";
            int startIndex = s.IndexOf(startTag) + startTag.Length;
            int endIndex = s.IndexOf("]", startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }

        private static string GetTagContent(string s, string tag)
        {
            if (!s.Contains(tag))
                return string.Empty;

            var startTag = string.Format("{0}=", tag);
            int startIndex = s.IndexOf(startTag) + startTag.Length;
            int endIndex = s.IndexOf(";", startIndex);
            if (endIndex < 0)
                endIndex = s.Length;

            var content = s.Substring(startIndex, endIndex - startIndex);

            if (string.IsNullOrWhiteSpace(content))
                return string.Empty;

            return content;
        }

        private static string GetName(string s)
        {
            int l = s.IndexOf("[");
            if (l > 0)
                return s.Substring(0, l).Trim();

            return s.Trim();
        }

        public static int DamerauLevenshteinDistance(string string1, string string2)
        {
            if (String.IsNullOrEmpty(string1))
            {
                if (!String.IsNullOrEmpty(string2))
                    return string2.Length;

                return 0;
            }

            if (String.IsNullOrEmpty(string2))
            {
                if (!String.IsNullOrEmpty(string1))
                    return string1.Length;

                return 0;
            }

            int length1 = string1.Length;
            int length2 = string2.Length;

            int[,] d = new int[length1 + 1, length2 + 1];

            int cost, del, ins, sub;

            for (int i = 0; i <= d.GetUpperBound(0); i++)
                d[i, 0] = i;

            for (int i = 0; i <= d.GetUpperBound(1); i++)
                d[0, i] = i;

            for (int i = 1; i <= d.GetUpperBound(0); i++)
            {
                for (int j = 1; j <= d.GetUpperBound(1); j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                        cost = 0;
                    else
                        cost = 1;

                    del = d[i - 1, j] + 1;
                    ins = d[i, j - 1] + 1;
                    sub = d[i - 1, j - 1] + cost;

                    d[i, j] = Math.Min(del, Math.Min(ins, sub));

                    if (i > 1 && j > 1 && string1[i - 1] == string2[j - 2] && string1[i - 2] == string2[j - 1])
                        d[i, j] = Math.Min(d[i, j], d[i - 2, j - 2] + cost);
                }
            }

            return d[d.GetUpperBound(0), d.GetUpperBound(1)];
        }
    }
}
