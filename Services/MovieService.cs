using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using DiziFilmUygulamas.Models;

namespace DiziFilmUygulamas_.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;


        //TODO Burda bi problem var spring boot bağlanması lazım ama onun için spring boot açabiliyo olmamız lazım
        // ve ben spring boot çalıştıramadım .m. gpt alttaki arkadaşı yorum satırına al geçici veri koy sayfaya dedi
        // şuan öyle duruyo
        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            // _httpClient.BaseAddress = new System.Uri("http://localhost:8080/"); // Spring Boot backend
        }


        public async Task<List<Movie>> GetFilmsAsync()
        {
            //return await _httpClient.GetFromJsonAsync<List<Movie>>("movies"); 
            return new List<Movie>
    {
        new Movie { Title = "Placeholder Movie", Genre = "Action" },
        new Movie { Title = "Another Movie", Genre = "Drama" }
    };





        }
    }
}
