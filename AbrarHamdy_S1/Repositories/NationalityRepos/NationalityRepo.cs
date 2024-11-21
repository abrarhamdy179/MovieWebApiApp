using AbrarHamdy_S1.Data;
using AbrarHamdy_S1.Dto.NationalityDtos;
using AbrarHamdy_S1.Models;

namespace AbrarHamdy_S1.Repositories.NationalityRepos
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly ApplicationDbContext _context;

        public NationalityRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddNationality(NationalDirectorDto nationalityDto)
        {
            Nationality nationality = new Nationality
            {
                NationalityName = nationalityDto.NationalityNameDto,
                director = new Director
                {
                    DirectorName = nationalityDto.DirectorDto.DirectorNameDto,
                    DirectorEmailAddress = nationalityDto.DirectorDto.DirectorEmailAddressDto,
                    DirectorContact = nationalityDto.DirectorDto.DirectorContactDto,
                }
            };
            _context.Nationalities.Add(nationality);
            _context.SaveChanges();
        }

        public void RemoveNationality(int id)
        {
            var national = _context.Nationalities.FirstOrDefault(i=>i.NationalityId == id);
            _context.Nationalities.Remove(national);
            _context.SaveChanges();
        }
    }
}
