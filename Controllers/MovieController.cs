using Microsoft.AspNetCore.Mvc;
using DiziFilmUygulamas_.Services;
using System.Threading.Tasks;

namespace DiziFilmUygulamas.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService _filmService;

        public MovieController(MovieService filmService)
        {
            _filmService = filmService;
        }

        public async Task<IActionResult> Index()
        {
            var films = await _filmService.GetFilmsAsync();
            return View(films);
        }
    }
}
