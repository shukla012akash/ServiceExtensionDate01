using DependencyInjectionSample01.Models;
using DependencyInjectionSample01.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionSample01.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _iMovieRepository;
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public MoviesController(IMovieRepository movieInterface)
        {
            _iMovieRepository = movieInterface;
        }
        public async Task<IActionResult> Index()
        {
            Movies = _iMovieRepository.GetAll();
            return View(Movies);
        }
    }
}
