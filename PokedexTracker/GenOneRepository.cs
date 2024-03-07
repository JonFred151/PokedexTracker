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
        public GenOne GetOneByDexId(int dexid)
        {
            return _conn.QueryFirstOrDefault<GenOne>("SELECT * FROM gen_one WHERE Dexid = @dexid;", new { dexid = dexid });
        }

        public void UpdateGenOne(GenOne genOne)
        {
            _conn.Execute("UPDATE gen_one SET pokemon = @Pokemon, type = @Type, obtainable = @Obtainable, method = @Method, isCauught = @isCaught WHERE Dexid = @Dexid;",
                new
                {
                    DexID = genOne.Dexid,
                    Pokemon = genOne.pokemon,
                    Type = genOne.type,
                    Obtainable = genOne.obtainable,
                    Method = genOne.method,
                    Iscaught = genOne.IsCauught
                });
        }
    }
}
 
