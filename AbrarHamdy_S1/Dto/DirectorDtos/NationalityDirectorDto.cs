using AbrarHamdy_S1.Dto.NationalityDtos;
using System.ComponentModel.DataAnnotations;

namespace AbrarHamdy_S1.Dto.DirectorDtos
{
    public class NationalityDirectorDto
    {
        [Required]
        public string DirectorNameDto { get; set; }
        [Phone]
        public string DirectorContactDto { get; set; }
        [EmailAddress]
        public string DirectorEmailAddressDto { get; set; }
        public NationalityDtoPost nationalityDtos { get; set; }

    }
}
