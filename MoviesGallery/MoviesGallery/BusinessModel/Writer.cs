using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.BusinessModel
{
    public class Writer : Person
    {
        public string role { get; set; }

        public Writer(string Name, string Role) : base (Name)
        {
            name = Name;
            role = Role;
        }
    }
}
