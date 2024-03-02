using Microsoft.AspNetCore.Mvc;
using Prelim_E2_Assignment_MalonesMaryChel_BSIT32E2.Models;
using System.Diagnostics;

namespace Prelim_E2_Assignment_MalonesMaryChel_BSIT32E2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schedule()
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
