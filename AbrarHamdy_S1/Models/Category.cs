namespace AbrarHamdy_S1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Movie> movies { get; set; }
    }
}
