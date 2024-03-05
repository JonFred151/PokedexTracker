using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using PokedexTracker.Models;
namespace PokedexTracker
{
    public class GenThreeRepository : IGenThreeRepository
    {
        private readonly IDbConnection _conn;
        public GenThreeRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<GenThree> GetAllThree()
        {
            return _conn.Query<GenThree>("SELECT * FROM gen_three;");
        }
        //    public void UpdateGenThree(GenThree genThree)
        //    {
        //        _conn.Execute("UPDATE gen_three SET isCaught = @isCaught WHERE (DEXID = @DEXID",
        //            new { Pokemon = genThree.Pokemon, isCaught = genThree.isCaught, Dexid = genThree.Dexid });
        //    }
    }
}