using Microsoft.AspNetCore.Mvc;
using RepoUnitTestPoc.Models;
using RepoUnitTestPoc.Services.Abstractions;

namespace RepoUnitTestPoc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _service;

        public MovieController(
            ILogger<MovieController> logger,
            IMovieService service
        )
        {
            _logger = logger;
            _service = service;
        }


        [HttpGet("{idMovie}")]
        public Movie Get([Bind]int idMovie)
        {
            var movie  = _service.Get(idMovie);
            return movie;
        }

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            var movies = _service.GetAll();
            return movies;
        }
    }
}
