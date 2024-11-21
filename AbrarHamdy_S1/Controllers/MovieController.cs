using AbrarHamdy_S1.Dto.MovieDtos;
using AbrarHamdy_S1.Repositories.MovieRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbrarHamdy_S1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _repo;

        public MovieController(IMovieRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddMovieWithDirectors")]
        public IActionResult AddMovieWithDirectors(AllMovieDto movieDto)
        {
            _repo.AddMovieWithDirectors(movieDto);
            return Created();
        }

        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            var movies = _repo.GetAllMovies();
            return Ok(movies);
        }

        [HttpGet("GetMovie")]
        public IActionResult GetMovie(int id)
        {
            var movies = _repo.GetMovie(id);
            if (movies == null)
            {
                return NotFound();
            }
            return Ok(movies);
        }
    }
}
