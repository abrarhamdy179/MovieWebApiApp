using AbrarHamdy_S1.Dto.CategoryDtos;
using AbrarHamdy_S1.Dto.DirectorDtos;
using AbrarHamdy_S1.Dto.NationalityDtos;

namespace AbrarHamdy_S1.Dto.MovieDtos
{
    public class AllMovieDto
    {
        public string MovieTitleDto { get; set; }
        public DateTime MovieReleaseYearDto { get; set; }
        public List<DirectorDtoPost> directorDtos { get; set; }
        public CategoryDtoPost categoryDtos { get; set; }
        public NationalityDtoPost nationalityDtos { get;set; }
    }
}
