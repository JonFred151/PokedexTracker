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
        
        public IActionResult UpdateGenThree(int Dexid, bool isChecked)
        {
            var genThree = repo.GetThreeByDexId(Dexid);
            if (genThree != null)
            {
                genThree.isCaught = isChecked ? 1 : 0;
                repo.UpdateGenThree(genThree);
                return Ok();
            }

            return NotFound();
        }
    }
}
