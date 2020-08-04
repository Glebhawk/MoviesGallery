using Microsoft.EntityFrameworkCore;
using MoviesGallery.DBContext;
using MoviesGallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Repositories
{
    public class PostgreRepository : IRepository
    {
        private MovieContext movieContext { get; set; }

        public IEnumerable<Movie> GetAll()
        {
            using (movieContext = new MovieContext())
            {
                return movieContext.movies
                    .Include("director")
                    .Include(m => m.genres_of_movie).
                    Include(m => m.actors_of_movie)
                    .ThenInclude(a => a.actor)
                    .Include(m => m.writers_of_movie)
                    .ThenInclude(w => w.writer)
                    .ToList(); // Why it is working now?
            }
        }

        public Movie GetById(int id)
        {
            return movieContext.movies.Find(id);
        }
    }
}
