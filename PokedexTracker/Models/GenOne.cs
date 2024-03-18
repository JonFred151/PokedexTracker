using System;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace PokedexTracker.Models
{
    public class GenOne
    {
        public int Dexid { get; set; }
        public string pokemon { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public string obtainable { get; set; } = string.Empty;
        public string method { get; set; } = string.Empty;
        public int IsCauught { get; set; }

        



     }
}
   
