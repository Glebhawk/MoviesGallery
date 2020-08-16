using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesGallery.EntityModel
{
    public class RatingEntity
    {
        public int id { get; set; }

        public int movieId { get; set; }
        public string title { get; set; }
        public string score { get; set; }
    }
}
