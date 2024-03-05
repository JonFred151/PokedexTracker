using Microsoft.AspNetCore.Mvc;
using PokedexTracker.Models;

namespace PokedexTracker.Controllers
{
    public class GenThreeController : Controller
    {
        private readonly IGenThreeRepository repo;
        public GenThreeController(IGenThreeRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var GenThree = repo.GetAllThree();
            return View(GenThree);
        }
        //public IActionResult UpdateGenOne(GenThree genThree)
        //{
        //    repo.UpdateGenThree(genThree);
        //    return RedirectToAction("Index");
        //}
    }
}
