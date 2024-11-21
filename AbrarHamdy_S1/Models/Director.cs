using System.ComponentModel.DataAnnotations;

namespace AbrarHamdy_S1.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        [Required]
        public string DirectorName { get; set; }
        [Phone]
        public string DirectorContact { get; set; }
        [EmailAddress]
        public string DirectorEmailAddress { get; set; }
        public List<Movie> movies { get; set; }
        public Nationality nationality { get; set; }
    }
}
