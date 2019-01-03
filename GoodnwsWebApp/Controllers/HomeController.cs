using GoodnwsWebApp.Models;
using GoodnwsWebApp.Services;
using GoodnwsWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoodnwsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStories _stories;

        public HomeController(IStories stories)
        {
            _stories = stories;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                Stories = _stories.GetStories(0)
            };
            return View(model);
        }

        public IActionResult GetMoreArticles([FromQuery]int page)
        {
            var model = new HomePageViewModel
            {
                Stories = _stories.GetStories(page + 1)
            };
            return PartialView("Articles", model);
        }

        public int GetTotalNumberOfArticles()
        {
            return _stories.GetTotalNumberOfStories();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
