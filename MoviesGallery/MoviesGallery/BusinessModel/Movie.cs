using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.BusinessModel
{
    public class Movie
    {
        public string title { get; set; }
        public int runtime { get; set; }
        public string plot { get; set; }
        public string posterLink { get; set; }

        public Person director { get; set; }
        public List<string> genresOfMovie { get; set; }
        public List<Person> actorsOfMovie { get; set; }
        public List<Writer> writersOfMovie { get; set; }

        public Movie(string Title, int Runtime, string Plot, string Posterlink, Person Director, List<string> Genres, List<Person> Actors, List<Writer> Writers)
        {
            title = Title;
            runtime = Runtime;
            plot = Plot;
            posterLink = Posterlink;
            director = Director;
            genresOfMovie = Genres;
            actorsOfMovie = Actors;
            writersOfMovie = Writers;
        }
    }
}
