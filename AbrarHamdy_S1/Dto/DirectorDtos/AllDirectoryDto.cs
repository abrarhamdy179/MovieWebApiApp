using AbrarHamdy_S1.Dto.CategoryDtos;
using AbrarHamdy_S1.Dto.MovieDtos;
using AbrarHamdy_S1.Dto.NationalityDtos;
using System.ComponentModel.DataAnnotations;

namespace AbrarHamdy_S1.Dto.DirectorDtos
{
    public class AllDirectoryDto
    {
        [Required]
        public string DirectorNameDto { get; set; }
        [Phone]
        public string DirectorContactDto { get; set; }
        [EmailAddress]
        public string DirectorEmailAddressDto { get; set; }
        public List<MovieDtoPost> movieDtos { get; set; }
        public NationalityDtoPost  nationalityDto {  get; set; }    
        public CategoryDtoPost categoryDto { get; set; }
    }
}
