using OnderMovieAnalyzer.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace OnderMovieAnalyzer.Helper
{
    public class XmlHelper
    {
        public static void WriteEmptyDatabase()
        {
            if (File.Exists(Program.DatabaseXmlFile))
                File.Delete(Program.DatabaseXmlFile);

            using (XmlWriter writer = XmlWriter.Create(Program.DatabaseXmlFile))
            {
                writer.WriteStartElement("OnderMovieDatabase");

                writer.WriteStartElement("Movies");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.Flush();
            }
        }




        public static List<Movie> ReadMovieList()
        {
            XDocument xdoc = XDocument.Load(Program.DatabaseXmlFile);
            return (from _movie in xdoc.Root.Element("Movies").Elements("Movie")
                    select new Movie
                    {
                        Guid = _movie.Element("Guid").Value,

                        Name = _movie.Element("Name").Value,
                        LanguageOriginal = _movie.Element("LanguageOriginal").Value,
                        LanguageDub = _movie.Element("LanguageDub").Value,
                        Quality = _movie.Element("Quality").Value,
                        Source = _movie.Element("Source").Value,
                        TvStation = _movie.Element("TvStation").Value,
                        Year = _movie.Element("Year").Value,

                        Location = _movie.Element("Location").Value,
                        Path = _movie.Element("Path").Value,
                        Size = Int64.Parse(_movie.Element("Size").Value),
                        LastModified = DateTime.ParseExact(_movie.Element("LastModified").Value, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)

                    }).ToList();
        }

        public static void AddMovie(Movie movieToAdd)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Movies").Add(
                 new XElement("Movie",
                        new XElement("Guid", movieToAdd.Guid),

                        new XElement("Name", movieToAdd.Name),
                        new XElement("LanguageOriginal", movieToAdd.LanguageOriginal),
                        new XElement("LanguageDub", movieToAdd.LanguageDub),
                        new XElement("Quality", movieToAdd.Quality),
                        new XElement("Source", movieToAdd.Source),
                        new XElement("TvStation", movieToAdd.TvStation),
                        new XElement("Year", movieToAdd.Year),

                        new XElement("Location", movieToAdd.Location),
                        new XElement("Path", movieToAdd.Path),
                        new XElement("Size", movieToAdd.Size),
                        new XElement("LastModified", movieToAdd.LastModified.ToString("yyyy-MM-dd HH:mm:ss"))
                        )
                 );

            doc.Save(Program.DatabaseXmlFile);
        }

        public static void DeleteMovie(Movie movieToDelete)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            doc.Root.Element("Movies").Elements("Movie").Where(e => e.Element("Guid").Value.Equals(movieToDelete.Guid)).Select(e => e).Single().Remove();

            doc.Save(Program.DatabaseXmlFile);
        }

        #region Updatespezifische Funktionen

        #endregion
    }
}
