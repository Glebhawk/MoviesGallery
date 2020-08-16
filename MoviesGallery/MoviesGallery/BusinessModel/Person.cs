using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.BusinessModel
{
    public class Person
    {
        public string name { get; set; }

        public Person(string Name)
        {
            name = Name;
        }
    }
}
