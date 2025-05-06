using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class RepertoiresController : Controller
    {
        private static List<Repertoire> _repertoires = new()
        {
            new Repertoire { Id = 1, Date = DateTime.Today, StartTime = new TimeSpan(18, 30, 0), Duration = new TimeSpan(2, 0, 0), TicketPrice = 120, MovieId = 1 }
        };

        public IActionResult Index() => View(_repertoires);
    }
}
