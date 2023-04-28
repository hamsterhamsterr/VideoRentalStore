using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesViewModel
    {
        private Dictionary<int, Movie> _movies;

        public MoviesViewModel()
        {
            _movies = new Dictionary<int, Movie>();
            _movies.Add(
                1, new Movie { Id = 1, Name = "Shrek" });
            _movies.Add(
                2, new Movie { Id = 2, Name = "Wall-e" });
        }

        public Movie GetMovieById(int id)
        {
            if (!_movies.ContainsKey(id))
                return null;
            return _movies[id];
        }

        public IEnumerable<Movie> Movies { get { return _movies.Values; } }
    }
}