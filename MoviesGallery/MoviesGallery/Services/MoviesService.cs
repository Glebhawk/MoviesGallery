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
        private IRepository moviesRepository { get; set; }

        public MoviesService()
        {
            moviesRepository = new PostgreRepository();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return moviesRepository.GetAll();
        }

        public Movie GetMovieById(int id)
        {
            return moviesRepository.GetById(id);
        } 
    }
}
