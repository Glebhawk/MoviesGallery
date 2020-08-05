using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesGallery.Model;
using MoviesGallery.Repositories;
using MoviesGallery.Services;

namespace MoviesGallery.Controllers
{
    [Route("api/gallery/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesService moviesService { get; set; }

        public MoviesController()
        {
            moviesService = new MoviesService();
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            {
                return moviesService.GetAllMovies();
            }
        }

        [HttpGet]
        [ExactQueryParam("participantId", "participantType", "programName")]
        public Movie Get(int id)
        {
            {
                throw new Exception();
                return moviesService.GetMovieById(id);
            }
        }

        //[HttpGet("search")]
        //public IEnumerable<Movie> Get(string search)
        //{
        //    {
        //        return moviesService.FindMoviesByTitle(search);
        //    }
        //}
    }
}
