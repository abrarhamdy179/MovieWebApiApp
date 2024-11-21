using AbrarHamdy_S1.Data;
using AbrarHamdy_S1.Dto.DirectorDtos;
using AbrarHamdy_S1.Dto.NationalityDtos;
using AbrarHamdy_S1.Models;
using Microsoft.EntityFrameworkCore;

namespace AbrarHamdy_S1.Repositories.DirectoryRepos
{
    public class DirectoryRepo : IDirectoryRepo
    {
        private readonly ApplicationDbContext _context;
        public DirectoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddDirectory(AllDirectoryDto directoryDto)
        {
            Director director = new Director
            {
               DirectorName = directoryDto.DirectorNameDto,
               DirectorContact = directoryDto.DirectorContactDto,
               DirectorEmailAddress = directoryDto.DirectorEmailAddressDto,
               movies = directoryDto.movieDtos.Select(i => new Movie
               {
                    MovieTitle = i.MovieTitleDto,
                    MovieReleaseYear = i.MovieReleaseYearDto,
                    category = new Category
                    {
                        CategoryName = directoryDto.categoryDto.CategoryNameDto,
                    },
               }).ToList(),
               nationality = new Nationality
               {
                   NationalityName = directoryDto.nationalityDto.NationalityNameDto,
               },
               
            };
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void RemoveDirectory(int id)
        {
            var director = _context.Directors.FirstOrDefault(i => i.DirectorId== id);
            if (director != null)
            {
                _context.Directors.Remove(director);
                _context.SaveChanges();
            }
        }

        public void UpdateDirectoryMovieCategory(int id, AllDirectoryDto directoryDto)
        {
            var director = _context.Directors
                .Include(n => n.nationality)
                .Include(m => m.movies)
                .ThenInclude(c => c.category).FirstOrDefault(i => i.DirectorId == id);

            director.DirectorName= directoryDto.DirectorNameDto;
            director.DirectorContact = directoryDto.DirectorContactDto;
            director.DirectorEmailAddress = directoryDto.DirectorEmailAddressDto;
            director.nationality.NationalityName = directoryDto.nationalityDto.NationalityNameDto;
            director.movies = directoryDto.movieDtos.Select(m=>new Movie
            {
                MovieTitle = m.MovieTitleDto,
                MovieReleaseYear = m.MovieReleaseYearDto,
                category = new Category
                {
                    CategoryName = directoryDto.categoryDto.CategoryNameDto,
                }
            }).ToList();
            _context.Directors.Update(director);
            _context.SaveChanges();

        }
    }
}
