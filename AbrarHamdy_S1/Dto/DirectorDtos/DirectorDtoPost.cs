using System.ComponentModel.DataAnnotations;

namespace AbrarHamdy_S1.Dto.DirectorDtos
{
    public class DirectorDtoPost
    {
        [Required]
        public string DirectorNameDto { get; set; }
        [Phone]
        public string DirectorContactDto { get; set; }
        [EmailAddress]
        public string DirectorEmailAddressDto { get; set; }
    }
}
