using FinalProject.ApplicationContaxt;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class CategoryController : Controller
    {
        MyContext db = new MyContext();
        [HttpGet]
        public IActionResult Index()
        {
            var categories = db.Categorys;
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int id) 
        {
            var Cat = db.Categorys.FirstOrDefault(p => p.CategoryId == id);
            if (Cat == null)
            {
                return RedirectToAction("Index");
            }
            return View(Cat);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            var existName = db.Categorys.FirstOrDefault(d => d.CategoryName == category.CategoryName);

            if (existName is not null)
            {
                ModelState.AddModelError("Name", "Name Already Exist");
                return View();

            }
            if (category != null && ModelState.IsValid)
            {
                db.Categorys.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "All Fields Required");
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = db.Categorys.Find(id);
            if (category == null)
                return RedirectToAction("Index");

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categorys.Update(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Delete(int id)
        {
            var category = db.Categorys.Find(id);
            if (category == null)
                return RedirectToAction("Index");

            db.Categorys.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
