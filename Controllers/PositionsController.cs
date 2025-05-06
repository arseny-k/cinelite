using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class PositionsController : Controller
    {
        private static List<Position> _positions = new()
        {
            new Position { Id = 1, Title = "Cashier", Salary = 15000, Duties = "Ticket sales", Requirements = "Experience, knowledge of the box office" },
            new Position { Id = 2, Title = "Manager", Salary = 25000, Duties = "Organization of shifts", Requirements = "Education, leadership" }
        };

        public IActionResult Index() => View(_positions);
    }
}
