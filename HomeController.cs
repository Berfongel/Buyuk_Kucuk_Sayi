using Microsoft.AspNetCore.Mvc;
using SayiKücükBüyükWebApplication.Models;
using System.Diagnostics;

namespace SayiKücükBüyükWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(SayiKücükBüyük sayiKücükBüyük)
        {
            var firstnumber = sayiKücükBüyük.Number1;
            var secondnumber = sayiKücükBüyük.Number2;
            var firstmessage = string.Empty;
            var secondmessage = string.Empty;
            if (firstnumber > secondnumber)
            {
                firstmessage = firstnumber + " büyük sayı.";
                secondmessage = secondnumber + " küçük sayı";

            }

            else if (firstnumber == secondnumber)
            {
                firstmessage = "Girilen sayılar birbirine eşittir.";
            }
            else
            {
                firstmessage = firstnumber + " küçük sayı";
                secondmessage = secondnumber + " büyük sayı";
            }

            ViewBag.FirstMessage = firstmessage;
            ViewBag.SecondMessage = secondmessage;
            return View("sayiKücükBüyük");
        }

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