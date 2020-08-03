using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Model
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
