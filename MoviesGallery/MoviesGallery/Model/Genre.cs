using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Model
{
    public class Genre
    {
        public int id { get; set; }
        public int movie_id { get; set; }
        public string title { get; set; }
    }
}
