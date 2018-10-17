using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Razor1.Models
{
    public class Beer_db
    {
        string cnnString = "Server=DB2; Database=ASP1; Trusted_Connections=true; MultipleActiveResultSets=true";

        public IEnumerable<Beer> getAllBeers()
        {
            // Result set we are going to return
            List<Beer> lstBeers = new List<Beer>();

            // using resolves all mem management issues
            using (SqlConnection conn = new SqlConnection(cnnString))
            {

            }

        }
    }
}
