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
                return movieContext.movies.Include(m => m.director).ToList(); // Why it isn`t working?
            }
        }

        public Movie GetById(int id)
        {
            return movieContext.movies.Find(id);
        }
    }
}
