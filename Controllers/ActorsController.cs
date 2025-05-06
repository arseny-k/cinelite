using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class ActorsController : Controller
    {
        private static List<Actor> _actors = new()
        {
            new Actor { Id = 1, Name = "Leonardo DiCaprio", AgeRestrictions = "13+", Description = "Famous Hollywood actor" }
        };

        public IActionResult Index() => View(_actors);
    }
}
