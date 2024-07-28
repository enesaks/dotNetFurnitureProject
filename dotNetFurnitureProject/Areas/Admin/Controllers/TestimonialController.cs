using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetFurnitureProject.DataAccess.Context;
using dotNetFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class TestimonialController : Controller
    {
        private readonly FurnitureContext _context;

        public TestimonialController(FurnitureContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _context.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTestimonial(int id)
        {
            var values= _context.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _context.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

