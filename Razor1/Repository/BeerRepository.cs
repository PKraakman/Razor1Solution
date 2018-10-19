using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Razor1.Models;
using System.Data.SqlClient;
using Dapper;

namespace Razor1.Repository
{
    public class BeerRepository : IBeerRepository
    {
        //provided by container thru constructor
        IConfiguration _configuration;
        SqlConnection _conn;

        public BeerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _conn = new SqlConnection(configuration.GetSection("ConnectionStrings").GetSection("ASP1").Value);
        }

        // Need this in every method
        //private static string GetConnectionString()
        //{
        //    return _configuration.GetSection("ConnectionStrings").GetSection("ASP1").Value;
        //}

        public int Add(Beer beer)
        {
            throw new NotImplementedException();
        }

        public int EditBeer(Beer beer)
        {
            throw new NotImplementedException();
        }

        public int DeleteBeer(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Beer> GetBeers()
        {
            var beers = new List<Beer>();
            
            using(_conn)
            {
                // conn.Open();
                var qry = "SELECT * FROM BEER";
                beers = _conn.Query<Beer>(qry).ToList();
            }

            return beers;
        }

        public Beer GetBeer(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
