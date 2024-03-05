using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenThreeRepository
    {
        public IEnumerable<GenThree> GetAllThree();

        //void UpdateGenTwo(GenTwo genTwo);
    }
}
