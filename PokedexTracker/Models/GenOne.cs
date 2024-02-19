using System;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace PokedexTracker.Models
{
    public class GenOne
    {
        public GenOne() { }


        public int Dexid { get; set; } 
        public string Pokemon { get; set; } =string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Obtainable { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
    }
   
}
