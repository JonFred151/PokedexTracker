﻿using System;
using System.Collections.Generic;
using PokedexTracker.Models;

namespace PokedexTracker
{
    public interface IGenOneRepository
    {
        public IEnumerable<GenOne> GetAllOne();
    }
}