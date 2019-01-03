using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoodnwsWebApp.Models;
using GoodnwsWebApp.Services;
using GoodnwsWebApp.ViewModels;

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
