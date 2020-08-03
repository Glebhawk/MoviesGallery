using MoviesGallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Repositories
{
    interface IRepository
    {
        public Movie GetById(int id);
        public IEnumerable<Movie> GetAll();
    }
}
