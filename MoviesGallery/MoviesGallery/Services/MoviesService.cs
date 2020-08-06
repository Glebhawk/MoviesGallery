using MoviesGallery.Model;
using MoviesGallery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Services
{
    public class MoviesService
    {
        private MovieRepository moviesRepository { get; set; }

        public MoviesService()
        {
            moviesRepository = new MovieRepository();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return moviesRepository.GetAll();
        }

        public Movie GetMovieById(int id)
        {
            return moviesRepository.GetById(id);
        }

        public IEnumerable<Movie> FindMoviesByTitleGenreDirector(string search)
        {
            return moviesRepository.FindAllByTitleDirectorGenre(search);
        }
    }
}
