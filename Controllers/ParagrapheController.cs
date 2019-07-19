using Microsoft.AspNetCore.Mvc;

namespace jeuDontVousEtesLeHeros.Controllers
{
    public class ParagrapheController : Controller
    {
        // GET
        public IActionResult Create()
        {
            return View();
        }
    }
}