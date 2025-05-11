using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CineLite.Data;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Employees
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.Include(e => e.Position).ToListAsync();
            return View(employees);
        }

        // GET: /Employees/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var employee = await _context.Employees.Include(e => e.Position)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null) return NotFound();

            return View(employee);
        }

        // GET: /Employees/Create
        public IActionResult Create()
        {
            ViewBag.Positions = _context.Positions.ToList();
            return View();
        }

        // POST: /Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("❌ ModelState invalid");
                foreach (var e in ModelState.Values.SelectMany(v => v.Errors))
                    Console.WriteLine($"⚠️ " + e.ErrorMessage);

                ViewBag.Positions = _context.Positions.ToList();
                return View(employee);
            }

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Employees/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null) return NotFound();

            ViewBag.Positions = _context.Positions.ToList();
            return View(employee);
        }

        // POST: /Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Positions = _context.Positions.ToList();
            return View(employee);
        }

        // GET: /Employees/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _context.Employees.Include(e => e.Position)
                .FirstOrDefaultAsync(e => e.Id == id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        // POST: /Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
