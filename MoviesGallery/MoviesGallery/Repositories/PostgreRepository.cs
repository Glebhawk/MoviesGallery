using Microsoft.EntityFrameworkCore;
using MoviesGallery.DBContext;
using MoviesGallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Repositories
{
    public class PostgreRepository : GenericRepository<Movie>
    {
        public override IEnumerable<Movie> GetAll()
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<Movie>()
                    .Include(m => m.director)
                    .Include(m => m.genres_of_movie)
                    .Include(m => m.actors_of_movie).ThenInclude(a => a.actor)
                    .Include(m => m.writers_of_movie).ThenInclude(w => w.writer)
                    .ToList(); // Why it is working now?
            }
        }

        public override Movie GetById(int id)
        {
            using(dbContext = new MovieContext())
            {
                return dbContext.Set<Movie>()
                    .Include(m => m.director)
                    .Include(m => m.genres_of_movie)
                    .Include(m => m.actors_of_movie).ThenInclude(a => a.actor)
                    .Include(m => m.writers_of_movie).ThenInclude(w => w.writer)
                    .Single(m => m.id == id);
            }
        }

        public IEnumerable<Movie> FindAllByTitleDirectorGenre(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return FindAllByTitle(search_string)
                .Union(FindAllByGenre(search_string))
                .Union(FindAllByDirector(search_string))
                .Include(m => m.director)
                .Include(m => m.genres_of_movie)
                .Include(m => m.actors_of_movie).ThenInclude(a => a.actor)
                .Include(m => m.writers_of_movie).ThenInclude(w => w.writer)
                .ToList();
            }
        }

        public IQueryable<Movie> FindAllByTitle(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<Movie>()
                    .Include(m => m.director)
                    .Include(m => m.genres_of_movie)
                    .Include(m => m.actors_of_movie).ThenInclude(a => a.actor)
                    .Include(m => m.writers_of_movie).ThenInclude(w => w.writer)
                    .Where(m => m.title.ToLower().Contains(search_string.ToLower()));
            }
        }

        public IQueryable<Movie> FindAllByGenre(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<Movie>()
                    .Include(m => m.genres_of_movie)
                    .Where(m => m.genres_of_movie
                    .Where(g => g.genre.ToLower().Contains(search_string.ToLower())).Count() > 0);
            }
        }

        public IQueryable<Movie> FindAllByDirector(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<Movie>()
                    .Include(m => m.director)
                    .Where(m => m.director.name.ToLower().Contains(search_string.ToLower()));
            }
        }
    }
}
