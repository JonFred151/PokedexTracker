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
        public GenThree GetThreeByDexId(int dexid)
        {
            return _conn.QueryFirstOrDefault<GenThree>("SELECT * FROM gen_Three WHERE Dexid = @dexid;", new { dexid = dexid });
        }
        public void UpdateGenThree(GenThree genThree)
        {
            _conn.Execute("UPDATE gen_Three SET pokemon = @Pokemon, type = @Type, obtainable = @Obtainable, method = @Method, isCauught = @isCaught WHERE Dexid = @Dexid;",
                   new
                   {
                       Dexid = genThree.Dexid,
                       Pokemon = genThree.Pokemon,
                       Type = genThree.Type,
                       Obtainable = genThree.Obtainable,
                       Method = genThree.Method,
                       isCaught = genThree.isCaught
                   });
        }
    }
}