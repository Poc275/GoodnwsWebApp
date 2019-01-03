using GoodnwsWebApp.Models;
using System.Linq;

namespace GoodnwsWebApp.ViewModels
{
    public class HomePageViewModel
    {
        public IQueryable<Story> Stories { get; set; }
    }
}
