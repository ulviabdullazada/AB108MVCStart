using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todos.Data;
using Todos.Models;

namespace Todos.Controllers
{
    public class TodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (AB108TodosContext _context = new AB108TodosContext())
            {
                return View(await _context.Todos.ToListAsync());
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Todo data)
        {
            data.IsDone = false;
            using (AB108TodosContext context = new())
            {
                await context.Todos.AddAsync(data);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
