using AbrarHamdy_S1.Data;
using AbrarHamdy_S1.Dto.CategoryDtos;
using AbrarHamdy_S1.Models;

namespace AbrarHamdy_S1.Repositories.CategoryRepos
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCategory(CategoryDtoPost categoryDto)
        {
            var cteg = _context.Categories.FirstOrDefault(i => i.CategoryName == categoryDto.CategoryNameDto);
            if (cteg != null)
            {
                throw new Exception("this Category already exists  ");
            }

            Category category = new Category
            {
                CategoryName = categoryDto.CategoryNameDto
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(CategoryDtoPost categoryDto, int id)
        {
            var category = _context.Categories.FirstOrDefault(i=> i.CategoryId == id);
            category.CategoryName = categoryDto.CategoryNameDto;    
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
