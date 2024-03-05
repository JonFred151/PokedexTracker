using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenTwoRepository
    {
        public IEnumerable<GenTwo> GetAllTwo();

        //void UpdateGenTwo(GenTwo genTwo);
    }
}
