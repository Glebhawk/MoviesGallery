using MoviesGallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviesGallery.Repositories
{
    public abstract class GenericRepository<T> where T : class
    {
        protected DbContext dbContext { get; set; }

        virtual public T GetById(int id)
        {
            return dbContext.Find<T>(id);
        }
        virtual public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }
    }
}
