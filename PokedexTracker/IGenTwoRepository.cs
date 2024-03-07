using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenTwoRepository
    {
        public IEnumerable<GenTwo> GetAllTwo();
        GenTwo GetTwoByDexId(int dexid);
        void UpdateGenTwo(GenTwo genTwo);
    }
}
