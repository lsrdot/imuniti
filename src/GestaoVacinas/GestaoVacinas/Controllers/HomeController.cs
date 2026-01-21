using GestaoVacinas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using GestaoVacinas.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GestaoVacinas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context) {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index() {
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var membros = await _context.Membros
				.Where(m => m.UserId == userId)
				.Include(m => m.Caderneta)
				.ToListAsync();

			ViewBag.Membros = membros;

			return View();
		}

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
