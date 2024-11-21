using AbrarHamdy_S1.Dto.MovieDtos;

namespace AbrarHamdy_S1.Repositories.MovieRepos
{
    public interface IMovieRepo
    {
        public List<AllMovieWithNationalityDto> GetAllMovies();
        public AllMovieWithNationalityDto GetMovie(int id);
        public void AddMovieWithDirectors(AllMovieDto movieDto);
    }
}
