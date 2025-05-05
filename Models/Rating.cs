using System.Text.Json.Serialization;

namespace DiziFilmUygulamas.Models
{
    public class Rating
    {

        public long Id { get; set; }

        public int Score { get; set; }

        public DateTime RatingDate { get; set; }

        public string Comment { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; }

        [JsonIgnore]
        public User User { get; set; }




        /*
        public int Id { get; set; }
        public int Score { get; set; } // Puan (1-10 arası)
        public string Comment { get; set; } // Yorum
        public int MovieId { get; set; }  // İlgili film
        public Movie Movie { get; set; }  // Film objesi ile ilişki
    
        */
    }
}
