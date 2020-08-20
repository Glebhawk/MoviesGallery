using Microsoft.EntityFrameworkCore;
using MoviesGallery.DBContext;
using MoviesGallery.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Repositories
{
    public class MovieRepository : GenericRepository<MovieEntity>
    {
        public override IEnumerable<MovieEntity> GetAll()
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<MovieEntity>()
                    .Include(m => m.director)
                    .Include(m => m.genresOfMovie)
                    .Include(m => m.actorsOfMovie).ThenInclude(a => a.actor)
                    .Include(m => m.writersOfMovie).ThenInclude(w => w.writer)
                    .ToList();
            }
        }

        public override MovieEntity GetById(int id)
        {
            using(dbContext = new MovieContext())
            {
                return dbContext.Set<MovieEntity>()
                    .Include(m => m.director)
                    .Include(m => m.genresOfMovie)
                    .Include(m => m.actorsOfMovie).ThenInclude(a => a.actor)
                    .Include(m => m.writersOfMovie).ThenInclude(w => w.writer)
                    .Single(m => m.id == id);
            }
        }

        public IEnumerable<MovieEntity> FindAllByTitleDirectorGenre(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return FindAllByTitle(search_string)
                .Union(FindAllByGenre(search_string))
                .Union(FindAllByDirector(search_string))
                .Include(m => m.director)
                .Include(m => m.genresOfMovie)
                .Include(m => m.actorsOfMovie).ThenInclude(a => a.actor)
                .Include(m => m.writersOfMovie).ThenInclude(w => w.writer)
                .ToList();
            }
        }

        public IQueryable<MovieEntity> FindAllByTitle(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<MovieEntity>()
                    .Where(m => m.title.ToLower().Contains(search_string.ToLower()));
            }
        }

        public IQueryable<MovieEntity> FindAllByGenre(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<MovieEntity>()
                    .Include(m => m.genresOfMovie)
                    .Where(m => m.genresOfMovie
                    .Where(g => g.genre.ToLower().Contains(search_string.ToLower())).Count() > 0);
            }
        }

        public IQueryable<MovieEntity> FindAllByDirector(string search_string)
        {
            using (dbContext = new MovieContext())
            {
                return dbContext.Set<MovieEntity>()
                    .Include(m => m.director)
                    .Where(m => m.director.name.ToLower().Contains(search_string.ToLower()));
            }
        }
    }
}
