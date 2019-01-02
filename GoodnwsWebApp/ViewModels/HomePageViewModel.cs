using GoodnwsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodnwsWebApp.ViewModels
{
    public class HomePageViewModel
    {
        public IQueryable<Story> Stories { get; set; }
    }
}
