using AbrarHamdy_S1.Dto.NationalityDtos;
using AbrarHamdy_S1.Repositories.NationalityRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbrarHamdy_S1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationalityRepo _repo;

        public NationalityController(INationalityRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddNationality")]
        public IActionResult AddNationality(NationalDirectorDto nationalityDto)
        {
            _repo.AddNationality(nationalityDto);
            return Ok();
        }
        [HttpDelete("RemoveNationality")]
        public IActionResult RemoveNationality(int id)
        {
            _repo.RemoveNationality(id);
            return Ok();    
        }

    }
}
