using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class SeatsController : Controller
    {
        private static List<Seat> _seats = new()
        {
            new Seat { Id = 1, RepertoireId = 1, SeatNumber = "A1", IsBooked = true, EmployeeId = 1 },
            new Seat { Id = 2, RepertoireId = 1, SeatNumber = "A2", IsBooked = false }
        };

        public IActionResult Index() => View(_seats);
    }
}
