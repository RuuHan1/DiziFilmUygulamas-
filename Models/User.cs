using System.Security.Cryptography.X509Certificates;

namespace DiziFilmUygulamas.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }

        private String password;

        private String email;

        private String role;

        public List<Rating> Ratings { get; set; } = new List<Rating>();

    }
}
