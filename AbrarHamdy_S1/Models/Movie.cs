namespace AbrarHamdy_S1.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public DateTime MovieReleaseYear { get; set; }
        public List<Director> directors { get; set; }
        public Category category { get; set; }

    }
}
