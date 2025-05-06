using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class GenresController : Controller
    {
        private static List<Genre> _genres = new()
        {
            new Genre { Id = 1, Name = "Action", Description = "Fast-paced movies with physical activities" },
            new Genre { Id = 2, Name = "Drama", Description = "Emotionally-driven storytelling" }
        };

        public IActionResult Index() => View(_genres);
    }
}
