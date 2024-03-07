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
        public IActionResult UpdateGenTwo(int Dexid, bool isChecked)
        {
            var genTwo = repo.GetTwoByDexId(Dexid);
            if (genTwo != null)
            {
                genTwo.isCaught = isChecked ? 1 : 0;
                repo.UpdateGenTwo(genTwo);
                return Ok();
            }

            return NotFound();
        }
    }
}
