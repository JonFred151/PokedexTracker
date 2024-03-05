using Microsoft.AspNetCore.Mvc;
using PokedexTracker.Models;

namespace PokedexTracker.Controllers
{
    public class GenTwoController : Controller
    {
        private readonly IGenTwoRepository repo;
        public GenTwoController(IGenTwoRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var GenTwo = repo.GetAllTwo();
            return View(GenTwo);
        }
        //public IActionResult UpdateGenOne(GenTwo genTwo)
        //{
        //    repo.UpdateGenTwo(genTwo);
        //    return RedirectToAction("Index");
        //}
    }
}
