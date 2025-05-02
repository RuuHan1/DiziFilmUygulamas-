namespace DiziFilmUygulaması.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; } // Puan (1-10 arası)
        public string Comment { get; set; } // Yorum
        public int MovieId { get; set; }  // İlgili film
        public Movie Movie { get; set; }  // Film objesi ile ilişki
    }
}
