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
        public GenOne GetPokemon(int id)
        {
            return _conn.QuerySingle <GenOne>("SELECT * FROM gen_one WHERE Dexid = @id;", new { id = id });
        }
        // update a specific
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
 
