using DZ_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DZ_4.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        // -------------- TASK 1 -------------------
        public IActionResult quote()
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            if(task1 != null)
            ViewBag.quote = task1.GetQuote();
            ViewBag.chars = task2.GetChar();
            // seed 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}