using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using PokedexTracker.Models;
namespace PokedexTracker
{
    public class GenOneRepository : IGenOneRepository
    {
        private readonly IDbConnection _conn;
        public GenOneRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<GenOne> GetAllOne()
        {
            return _conn.Query<GenOne>("SELECT * FROM gen_one;");
        }
        public void UpdateGenOne(GenOne genOne)
        {
            _conn.Execute("UPDATE gen_one SET isCaught = @isCaught WHERE (DEXID = @DEXID",
                new {Pokemon = genOne.Pokemon, isCaught = genOne.isCaught, Dexid = genOne.Dexid});
        }
    }
}
 
