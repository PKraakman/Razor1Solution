using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1.Repository;
using Razor1.Models;

namespace Razor1.Areas.Beers.Pages
{
    public class ShowModel : PageModel
    {
        private IBeerRepository _repository;
        public string Message { get; set; }
        public List<Beer> beers { get; set; }




        public ShowModel(IBeerRepository repository)
        {
            _repository = repository;
        }


        public void OnGet()
        {
            Message = "I am message from OnGet method";

            beers = _repository.GetBeers();


        }
    }

 
}