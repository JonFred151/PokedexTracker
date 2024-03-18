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
        public IActionResult ViewGenOne (int id)
        {
            var ViewGenOne = repo.GetPokemon(id);
            return View(ViewGenOne);
        }
        public IActionResult UpdateGenOne(int id) 
        {
            var genOne = repo.GetPokemon(id);
            if (genOne == null)
            {
                return NotFound();
                
            }
            repo.UpdateGenOne(genOne);
            return View(genOne);

        }
        public IActionResult UpdatePokemonToDatabase(GenOne genOne) 
        {
            repo.UpdateGenOne(genOne);

            return RedirectToAction("ViewGenOne", new {id= genOne.Dexid});
        }

    }
}
