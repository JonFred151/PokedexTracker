using Microsoft.AspNetCore.Mvc;
using PokedexTracker.Models;

namespace PokedexTracker.Controllers
{
    public class GenOneController : Controller
    {
        private readonly IGenOneRepository repo;
        public GenOneController(IGenOneRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var GenOne = repo.GetAllOne();
            return View(GenOne);
        }
        public IActionResult UpdateGenOne(GenOne genOne) 
        {
            repo.UpdateGenOne(genOne);
            return RedirectToAction("Index");
        }
    }
}
