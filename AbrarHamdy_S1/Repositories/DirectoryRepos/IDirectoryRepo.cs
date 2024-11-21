using AbrarHamdy_S1.Dto.DirectorDtos;

namespace AbrarHamdy_S1.Repositories.DirectoryRepos
{
    public interface IDirectoryRepo
    {
        public void AddDirectory(AllDirectoryDto directoryDto);
        public void UpdateDirectoryMovieCategory(int id, AllDirectoryDto directoryDto);
        public void RemoveDirectory(int id);
    }
}
