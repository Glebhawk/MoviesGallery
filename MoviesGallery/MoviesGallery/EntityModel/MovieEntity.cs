using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.EntityModel
{
    public class MovieEntity
    {
        public int id { get; set; }
        public string title { get; set; }
        public int runtime { get; set; }
        public string plot { get; set; }
        public string posterLink { get; set; }

        public PersonEntity director { get; set; }
        public List<Genre> genresOfMovie { get; set; }
        public List<ActorOfMovie> actorsOfMovie { get; set; }
        public List<WriterOfMovie> writersOfMovie { get; set; }
    }
}
