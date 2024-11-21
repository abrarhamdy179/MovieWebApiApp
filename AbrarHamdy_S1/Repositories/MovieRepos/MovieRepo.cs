using AbrarHamdy_S1.Data;
using AbrarHamdy_S1.Dto.MovieDtos;
using AbrarHamdy_S1.Models;
using Microsoft.EntityFrameworkCore;

namespace AbrarHamdy_S1.Repositories.MovieRepos
{
    public class MovieRepo : IMovieRepo
    {
       private readonly ApplicationDbContext _context;

        public MovieRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddMovieWithDirectors(AllMovieDto movieDto)
        {
            var movi = _context.Movies.FirstOrDefault(i => i.MovieTitle == movieDto.MovieTitleDto);
            if (movi != null)
            {
                throw new Exception("this Movie already exists  ");
            }
            Movie movie = new Movie
            {
                MovieTitle = movieDto.MovieTitleDto,
                MovieReleaseYear = movieDto.MovieReleaseYearDto,
                directors = movieDto.directorDtos.Select(i => new Director
                {
                    DirectorName = i.DirectorNameDto,
                    DirectorContact = i.DirectorContactDto,
                    DirectorEmailAddress = i.DirectorEmailAddressDto,
                }).ToList(),
                category = new Category
                {
                    CategoryName = movieDto.categoryDtos.CategoryNameDto,
                }
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public List<AllMovieWithNationalityDto> GetAllMovies()
        {
            var movieList = _context.Movies
                .Include(c => c.category)
                .Include(d => d.directors)
                .ThenInclude(n => n.nationality)
                .Select(m => new AllMovieWithNationalityDto
                {
                    MovieTitleDto = m.MovieTitle,
                    MovieReleaseYearDto = m.MovieReleaseYear, 

                    directorDtos = m.directors.Select(s => new Dto.DirectorDtos.NationalityDirectorDto
                    {
                        DirectorNameDto = s.DirectorName,
                        DirectorContactDto = s.DirectorContact,
                        DirectorEmailAddressDto = s.DirectorEmailAddress,
                        nationalityDtos = new Dto.NationalityDtos.NationalityDtoPost
                        {
                            NationalityNameDto = s.nationality.NationalityName,
                        },
                    }).ToList(),
                    categoryDtos = new Dto.CategoryDtos.CategoryDtoPost
                    {
                        CategoryNameDto =m.category.CategoryName,
                    }
                })
                .ToList();
            return movieList;
        }

        public AllMovieWithNationalityDto GetMovie(int id)
        {
            var movie = _context.Movies.Where(i => i.MovieId == id)
                .Include(c => c.category)
                .Include(d => d.directors)
                .ThenInclude(n => n.nationality)
                .Select(m => new AllMovieWithNationalityDto
                {
                    MovieTitleDto = m.MovieTitle,
                    MovieReleaseYearDto = m.MovieReleaseYear,
                    directorDtos = m.directors.Select(s => new Dto.DirectorDtos.NationalityDirectorDto
                    {
                        DirectorNameDto = s.DirectorName,
                        DirectorContactDto = s.DirectorContact,
                        DirectorEmailAddressDto = s.DirectorEmailAddress,
                        nationalityDtos = new Dto.NationalityDtos.NationalityDtoPost
                        {
                            NationalityNameDto = s.nationality.NationalityName,
                        },
                    }).ToList(),
                    categoryDtos = new Dto.CategoryDtos.CategoryDtoPost
                    {
                        CategoryNameDto = m.category.CategoryName,
                    }
                }).ToList()
                .FirstOrDefault();
            return movie;
        }
    }
}
