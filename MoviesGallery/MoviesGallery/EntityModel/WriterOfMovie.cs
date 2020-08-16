using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesGallery.EntityModel
{
    public class WriterOfMovie
    {
        public int id { get; set; }
        public int movieid { get; set; }

        public PersonEntity writer { get; set; }

        public string role { get; set; }
    }
}
