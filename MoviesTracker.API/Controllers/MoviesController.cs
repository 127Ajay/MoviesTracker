using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesTracker.Application.Repositories;

namespace MoviesTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
    }
}
