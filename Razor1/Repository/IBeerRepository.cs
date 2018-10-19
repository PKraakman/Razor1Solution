using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Razor1.Models;

namespace Razor1.Repository
{
    public interface IBeerRepository
    {
        int Add(Beer beer);
        int EditBeer(Beer beer);
        int DeleteBeer(int Id);
        List<Beer> GetBeers();
        Beer GetBeer(int Id);
    }
}
