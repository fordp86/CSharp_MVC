using CSharp_MVC.CarInfo;
using CSharp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharp_MVC.Controllers
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

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult BMWInfo() 
        {
            BMW myCar = new();

            myCar.Year = 2023;
            myCar.Color = "Black";
            myCar.Passengers = 4;
            myCar.Speed = 0;
            myCar.FuelLevel = 1.0M;

            return View(myCar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BMWInfo(BMW car, string move)
        {
            if (move == "Faster")
            {
               car.Accelerate();
            }if(move == "Slower")
            {
                car.Decelerate();
            }
            if(move == "Power")
            {
                car.Decelerate(true);
            }
            return View(car);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}