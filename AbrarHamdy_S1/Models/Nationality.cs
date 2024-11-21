namespace AbrarHamdy_S1.Models
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public Director director { get; set; }
        public int DirectorId { get; set; }

    }
}
