using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jeuDontVousEtesLeHeros.Models;

namespace jeuDontVousEtesLeHeros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.monTableau = new[] {1, 2, 3, 4, 5};
            return View();
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
