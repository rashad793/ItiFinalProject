using FinalProject.ApplicationContaxt;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class UserController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)     // <===== Index.cshtml -- Create User
        {
            var ExistingEmail = db.Users.FirstOrDefault(e => e.Email == user.Email);

            if (ExistingEmail is not null)
            {
                ModelState.AddModelError("", "Email Already Exist");

                return View();
            }
            if (user != null && ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ModelState.AddModelError("", "All Field Required");
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user is not null)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ViewBag.Error = "Invalid credentials!";
               
            } 
            return View();
        }
    }
}
