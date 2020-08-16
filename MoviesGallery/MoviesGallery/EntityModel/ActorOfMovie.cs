using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesGallery.EntityModel
{
    public class ActorOfMovie
    {
        public int id { get; set; }
        public int movieid { get; set; }
        
        public PersonEntity actor { get; set; }
    }
}
