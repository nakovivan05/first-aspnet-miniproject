using Microsoft.AspNetCore.Mvc;
using NumberGenerator.Models;
using System.Diagnostics;

namespace NumberGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Numbers(int id)
        {
            int numbersRange = id;
            ViewBag.NumbersRange = numbersRange;
            return View();
        }
        [HttpPost]
        public IActionResult Numbers(string number)
        {
            ViewBag.numbersRange = int.Parse(number);
            return View();
        }
    
    }
}
