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
        public GenOneRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<GenOne> GetAll()
        {
            return _conn.Query<gen_one>("SELECT * FROM gen_one;");
        }
    }
}
 
