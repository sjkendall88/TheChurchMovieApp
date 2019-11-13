using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheChurchMovieApp.Controllers
{
    public class TheChurchMovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string Name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + Name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}