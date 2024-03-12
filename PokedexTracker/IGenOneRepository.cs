using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenOneRepository
    {
        public IEnumerable<GenOne> GetAllOne();
        GenOne GetOneByDexId(int dexid);
        void UpdateGenOne(GenOne genOne);

        //updating Gen One Type/method to database
        GenOne GetgOne(int dexid);
        void UpdategOne(GenOne genOne);

    }
}
