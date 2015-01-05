
using System;
namespace OnderMovieAnalyzer.Objects
{
    public class Movie
    {
        public string Guid { get; set; }

        public string Name { get; set; }
        public string LanguageOriginal { get; set; }
        public string LanguageDub { get; set; }
        public string Quality { get; set; }
        public string Source { get; set; }
        public string TvStation { get; set; }
        public string Year { get; set; }

        public string Path { get; set; }
        public long Size { get; set; }
        public DateTime LastModified { get; set; }
        public string Location { get; set; }

        public string FullSource
        {
            get { return string.Format("{0} | {1}", Source, TvStation); }
        }

        public string FullPath
        {
            get { return string.Format(@"{0}\\{1}", Location, Path); }
        }
    }
}
