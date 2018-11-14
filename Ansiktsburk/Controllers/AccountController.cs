using Ansiktsburk.DAL;
using Ansiktsburk.Models;
using Microsoft.AspNetCore.Mvc;
using Ansiktsburk.ViewModels;

namespace Ansiktsburk.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterFormViewModel user)
        {
            User newUser = new User
            {
                Username = user.Username,
                Password = user.Password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            //return RedirectToAction("Index", "Home");
            return View();
        }
    }
}
