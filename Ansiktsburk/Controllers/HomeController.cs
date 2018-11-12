using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ansiktsburk.Models;

namespace Ansiktsburk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var p = new Post {
                Author = "Kågge",
                Timestamp = DateTime.Now,
                Body = "Hej världen"
            };
            
            return View(p);
        }

        [HttpPost]
        public ActionResult Report(Post post)
        {
            return View();
        }

        //public ActionResult Create()
        //{
        //    var 
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
