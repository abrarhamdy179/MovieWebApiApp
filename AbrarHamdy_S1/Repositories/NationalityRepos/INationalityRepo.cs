using AbrarHamdy_S1.Dto.NationalityDtos;

namespace AbrarHamdy_S1.Repositories.NationalityRepos
{
    public interface INationalityRepo
    {
        public void AddNationality (NationalDirectorDto nationalityDto);
        public void RemoveNationality(int id);
    }
}
