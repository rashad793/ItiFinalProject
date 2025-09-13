using FinalProject.ApplicationContaxt;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class ProductController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products.Include(c => c.Category);
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = db.Products.Include(c => c.Category).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = new SelectList(db.Categorys, "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ModelState.Remove("Category");
            if (product != null && ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges(); /////
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "All Field Required");
            ViewBag.Categorys = new SelectList(db.Categorys, "CategoryId", "CategoryName");
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = db.Products.Include(e => e.Category).FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Categorys = new SelectList(db.Categorys, "CategoryId", "CategoryName");
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ModelState.Remove("Category");
            if (product != null && ModelState.IsValid)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "All Field Required");
            ViewBag.Categorys = new SelectList(db.Categorys, "CategoryId", "CategoryName");
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {   
                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            
            return View();
        }
    }
}
