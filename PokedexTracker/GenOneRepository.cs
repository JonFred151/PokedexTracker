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
        // Send the check mark data to database
        public GenOne GetOneByDexId(int dexid)
        {
            return _conn.QuerySingle<GenOne>("SELECT * FROM gen_one WHERE Dexid = @dexid;", new { dexid = dexid });
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
        //end of checkmark data being sent to database
        //Update Gen one Type and Method
        public void UpdategOne(GenOne genOne)
        {
            _conn.Execute("UPDATE gen_one SET type = @Type, method = @Method WHERE Dexid = @Dexid",
               new {
                DexID =genOne.Dexid,
                Type = genOne.type,
                 Method = genOne.method
                    });
        }

    }
}
 
