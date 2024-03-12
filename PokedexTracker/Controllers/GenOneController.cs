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
        public IActionResult UpdateGenOne(int Dexid, bool isChecked) 
        {
            var genOne = repo.GetOneByDexId(Dexid);
            if (genOne != null)
            {
                genOne.IsCauught = isChecked ? 1 : 0;
                repo.UpdateGenOne(genOne);
                return View(genOne);
            }            
            
            return NotFound();
        }

        // update for type and method
        public IActionResult UpdategOne(int dexid)
        {
            GenOne one = repo.GetgOne(dexid);
            if(one == null)
            {
                return View("Not Found");
            }
            return View(one);
        }
    }
}
