using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Model
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public int runtime { get; set; }
        public string plot { get; set; }
        public string poster_link { get; set; }
        public Person director { get; set; }
        public List<Genre> genres { get; set; }
        public List<Person> actors { get; set; }
        public List<Writer> writers { get; set; }
    }
}
