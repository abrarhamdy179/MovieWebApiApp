using AbrarHamdy_S1.Dto.DirectorDtos;
using AbrarHamdy_S1.Repositories.DirectoryRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbrarHamdy_S1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectoryRepo _repo;

        public DirectorController(IDirectoryRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("AddDirectory")]
        public IActionResult AddDirectory(AllDirectoryDto directoryDto)
        {
            _repo.AddDirectory(directoryDto);
            return Ok();
        }
        [HttpDelete("RemoveDirectory")]

        public IActionResult RemoveDirectory(int id)
        {
            _repo.RemoveDirectory(id);
            return Ok();
        }

        [HttpPut("UpdateDirectoryMovieCategory")]
        public IActionResult UpdateDirectoryMovieCategory(int id, AllDirectoryDto directoryDto)
        {
            _repo.UpdateDirectoryMovieCategory(id, directoryDto);
            return Ok();
        }
    }
}
