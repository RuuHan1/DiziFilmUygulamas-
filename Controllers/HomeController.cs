using System.Diagnostics;
using DiziFilmUygulamas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiziFilmUygulamas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieRatingContext _context;

        public HomeController(MovieRatingContext context)
        {
            _context = context;
        }

        //bu çalışınca viev dönüyor
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies); // Movies view'ına veriyi gönderiyoruz
        }

        // Film detayları
        public IActionResult Details(int id)
        {
            var movie = _context.Movies
                                .Where(m => m.Id == id)
                                .Include(m => m.Ratings)
                                .FirstOrDefault();
            return View(movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
