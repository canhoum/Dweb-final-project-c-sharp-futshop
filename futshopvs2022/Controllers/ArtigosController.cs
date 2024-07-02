using Microsoft.AspNetCore.Mvc;
using futshopvs2022.Models;

namespace futshopvs2022.Controllers
{
    public class ArtigosController : Controller
    {
        // Buscar: Artigos/random
        public IActionResult Random()
        {
            var artigo = new Artigos() { Name = "Benfica" };
            return View(artigo);
        }
    }
}
