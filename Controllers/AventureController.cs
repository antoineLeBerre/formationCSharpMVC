using System.Collections.Generic;
using jeuDontVousEtesLeHeros.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuDontVousEtesLeHeros.Controllers
{
    public class AventureController : Controller
    {
        // GET
        public IActionResult Index()
        {
            List<Aventure> maListe = new List<Aventure>
            {
                new Aventure {Id = 1, Titre = "Ma 1ere Aventure"},
                new Aventure {Id = 2, Titre = "Ma 2eme Aventure"},
                new Aventure {Id = 3, Titre = "Ma 3eme Aventure"},
                new Aventure {Id = 4, Titre = "Ma 4eme Aventure"}
            };

            ViewBag.Titre = "Aventure";
            
            return View(maListe);
        }
        
        public IActionResult Create()
        {
            ViewBag.Titre = "Aventures";
            ViewBag.monTableau = new[] {1, 2, 3, 4, 5};
            return View();
        }
    }
}