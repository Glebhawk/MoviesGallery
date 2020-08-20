using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesGallery.BusinessModel;
using MoviesGallery.EntityModel;
using MoviesGallery.Repositories;
using MoviesGallery.Services;

namespace MoviesGallery.Controllers
{
    [Route("api/gallery/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesService moviesService { get; set; } // Truly, I can use repository with same result

        public MoviesController()
        {
            moviesService = new MoviesService();
        }

        //api/movies
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            {
                return moviesService.GetAllMovies();
            }
        }

        //api/movies/id=1
        [HttpGet("id={id}")]
        public Movie Get(int id)
        {
            {
                return moviesService.GetMovieById(id);
            }
        }

        //api/movies/search=rogue
        [HttpGet("search={search}")]
        public IEnumerable<Movie> Get(string search)
        {
            {
                return moviesService.FindMoviesByTitleGenreDirector(search);
            }
        }
    }
}
