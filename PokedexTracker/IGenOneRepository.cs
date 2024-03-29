﻿using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenOneRepository
    {
        public IEnumerable<GenOne> GetAllOne();       
        GenOne GetPokemon(int id);
        void UpdateGenOne(GenOne genOne);
        public void CreatePokemon(GenOne genOne);
        public GenOne AssignVaule();
        public void DeletePokemon(GenOne genOne);

        //updating Gen One Type/method to database
       // GenOne GetgOne(int dexid);
        //void UpdategOne(GenOne genOne);

    }
}
