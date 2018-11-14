using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ansiktsburk.DAL;
using Microsoft.AspNetCore.Mvc;
using Ansiktsburk.Models;
using Ansiktsburk.ViewModels;

namespace Ansiktsburk.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(PostFormViewModel viewModel)
        {
            Post newPost = new Post
            {
                Body = viewModel.Body,
                Author = viewModel.Author,
                Timestamp = viewModel.GetTimeStamp()
            };

            _context.Posts.Add(newPost);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}