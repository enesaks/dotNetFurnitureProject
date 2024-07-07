using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetFurnitureProject.DataAccess.Context;
using dotNetFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly FurnitureContext _context;
        public ProductController(FurnitureContext context)
        {
            _context = context; 
        }
        
        public IActionResult Index()
        {
            var values = _context.Products.ToList();
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            var values = _context.Products.Find(id);
            _context.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Update(value);
            _context.SaveChanges();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

