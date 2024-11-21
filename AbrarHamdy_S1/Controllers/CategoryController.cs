using AbrarHamdy_S1.Dto.CategoryDtos;
using AbrarHamdy_S1.Repositories.CategoryRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbrarHamdy_S1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repo;

        public CategoryController(ICategoryRepo repo)
        {
            _repo = repo;
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(CategoryDtoPost categoryDto)
        {
            _repo.AddCategory(categoryDto);
            return Ok();
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(CategoryDtoPost categoryDto, int id)
        {
            _repo.UpdateCategory(categoryDto, id);
            return Ok();    
        }
    }
}
