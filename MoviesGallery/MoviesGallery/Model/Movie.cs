using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public List<Genre> genres_of_movie { get; set; }
        public List<Actors_of_movie> actors_of_movie { get; set; }
        public List<Writers_of_movie> writers_of_movie { get; set; }
    }
}
