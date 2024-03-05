using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using PokedexTracker.Models;
namespace PokedexTracker
{
    public class GenTwoRepository : IGenTwoRepository
    {
        private readonly IDbConnection _conn;
        public GenTwoRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<GenTwo> GetAllTwo()
        {
            return _conn.Query<GenTwo>("SELECT * FROM gen_two;");
        }
    //    public void UpdateGenTwo(GenTwo genTwo)
    //    {
    //        _conn.Execute("UPDATE gen_two SET isCaught = @isCaught WHERE (DEXID = @DEXID",
    //            new { Pokemon = genTwo.Pokemon, isCaught = genTwo.isCaught, Dexid = genTwo.Dexid });
    //    }
    }
}
