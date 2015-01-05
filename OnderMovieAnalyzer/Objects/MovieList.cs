using OnderMovieAnalyzer.Helper;
using System.Collections.Generic;
using System.Linq;

namespace OnderMovieAnalyzer.Objects
{
    public class MovieList
    {
        private List<Movie> _movies = new List<Movie>();

        public MovieList()
        {
            _movies = XmlHelper.ReadMovieList().OrderBy(t => t.Name).ToList();
        }

        public List<Movie> GetMovieList()
        {
            return _movies;
        }

        public void AddMovieToList(Movie movieToAdd)
        {
            if (_movies.Where(p => p.Guid == movieToAdd.Guid ||
                                   (p.Path == movieToAdd.Path && p.Location == movieToAdd.Location))
                                   .FirstOrDefault() != null)
                return;

            _movies.Add(movieToAdd);
            XmlHelper.AddMovie(movieToAdd);
        }

        public void DeleteMovie(Movie movieToDelete)
        {
            _movies.Remove(movieToDelete);

            XmlHelper.DeleteMovie(movieToDelete);
            FileHelper.DeleteMovie(movieToDelete);
        }
    }
}
