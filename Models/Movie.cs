namespace DiziFilmUygulaması.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public List<Rating> Ratings { get; set; } // Filmle ilişkili puanlamalar
    }
}
