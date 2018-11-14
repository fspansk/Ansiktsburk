using Ansiktsburk.DAL;
using Ansiktsburk.Models;
using Microsoft.AspNetCore.Mvc;
using Ansiktsburk.ViewModels;
using System.Linq;

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

            return RedirectToAction("Login", "Account");

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var existingUser = _context.Users.SingleOrDefault(x => x.Username == user.Username);


            if (existingUser != null && existingUser.Password == user.Password)
            {
                return Content(existingUser.Username);
            }
            else
                return View(user);
            
        }
    }
}
