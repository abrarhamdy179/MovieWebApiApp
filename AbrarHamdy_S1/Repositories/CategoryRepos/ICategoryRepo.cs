using AbrarHamdy_S1.Dto.CategoryDtos;

namespace AbrarHamdy_S1.Repositories.CategoryRepos
{
    public interface ICategoryRepo
    {
        public void AddCategory(CategoryDtoPost categoryDto);
        public void UpdateCategory(CategoryDtoPost categoryDto, int id);
    }
}
