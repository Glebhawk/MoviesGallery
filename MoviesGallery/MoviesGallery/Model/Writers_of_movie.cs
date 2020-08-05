using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Model
{
    public class Writers_of_movie
    {
        public int id { get; set; }
        public int movieid { get; set; }

        public int writerid { get; set; }
        public Person writer { get; set; }

        public string role { get; set; }
    }
}
