using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenThreeRepository
    {
        public IEnumerable<GenThree> GetAllThree();
        GenThree GetThreeByDexId(int dexid);
        void UpdateGenThree(GenThree genThree);
    }
}
