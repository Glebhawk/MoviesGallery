using MoviesGallery.BusinessModel;
using MoviesGallery.EntityModel;
using MoviesGallery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesGallery.Services
{
    public class MoviesService
    {
        private MovieRepository moviesRepository { get; set; }

        public MoviesService()
        {
            moviesRepository = new MovieRepository();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            List <Movie> movies = new List<Movie>();
            foreach(MovieEntity me in moviesRepository.GetAll())
            {
                movies.Add(TransferEntityToMovie(me));
            }
            return movies;
        }

        public Movie GetMovieById(int id)
        {
            return TransferEntityToMovie(moviesRepository.GetById(id));
        }

        public IEnumerable<Movie> FindMoviesByTitleGenreDirector(string search)
        {
            List<Movie> movies = new List<Movie>();
            foreach (MovieEntity me in moviesRepository.FindAllByTitleDirectorGenre(search))
            {
                movies.Add(TransferEntityToMovie(me));
            }
            return movies;
        }

        public Movie TransferEntityToMovie(MovieEntity movieEntity)
        {
            Person director = new Person(movieEntity.director.name);

            List<string> genres = new List<string>();
            foreach (Genre g in movieEntity.genresOfMovie)
            {
                genres.Add(g.genre);
            }

            List<Person> actors = new List<Person>();
            foreach (ActorOfMovie pe in movieEntity.actorsOfMovie)
            {
                actors.Add(new Person(pe.actor.name));
            }

            List<Writer> writers = new List<Writer>();
            foreach (WriterOfMovie w in movieEntity.writersOfMovie)
            {
                writers.Add(new Writer(w.writer.name, w.role));
            }

            return new Movie(movieEntity.title, movieEntity.runtime, movieEntity.plot, movieEntity.posterLink, director, genres, actors, writers);
        }
    }
}
