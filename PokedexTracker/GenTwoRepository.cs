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
        public GenTwo GetTwoByDexId(int dexid)
        {
            return _conn.QueryFirstOrDefault<GenTwo>("SELECT * FROM gen_Two WHERE Dexid = @dexid;", new { dexid = dexid });
        }

        public void UpdateGenTwo(GenTwo genTwo)
        {
            _conn.Execute("UPDATE gen_Two SET pokemon = @Pokemon, type = @Type, obtainable = @Obtainable, method = @Method, isCauught = @isCaught WHERE Dexid = @Dexid;",
                new
                {
                    Dexid = genTwo.Dexid,
                    Pokemon = genTwo.Pokemon,
                    Type = genTwo.Type,
                    Obtainable = genTwo.Obtainable,
                    Method = genTwo.Method,
                    isCaught = genTwo.isCaught
                });
        }
    }
}
