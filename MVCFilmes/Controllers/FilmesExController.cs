using Microsoft.AspNetCore.Mvc;

namespace MVCFilmes.Controllers
{
    public class FilmesExController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo(string nome, int id)
        {
            ViewData["Title"] = "Bem vindo";

            ViewData["Nome"] = nome;
            ViewData["NumeroX"] = id;

            return View();
        }
    }
}
