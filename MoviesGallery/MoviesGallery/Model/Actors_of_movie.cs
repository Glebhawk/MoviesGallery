using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Model
{
    public class Actors_of_movie
    {
        public int id { get; set; }
        public int movieid { get; set; }

        public int actorid { get; set; }
        public Person actor { get; set; }
    }
}
