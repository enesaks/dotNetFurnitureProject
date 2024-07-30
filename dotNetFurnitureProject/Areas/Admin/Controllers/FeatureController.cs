using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Entities;
using dotNetFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class FeatureController : Controller
    {
        private readonly FurnitureContext _context;

        public FeatureController(FurnitureContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var values = _context.Features.ToList();
            return View(values);
        }

        public IActionResult DeleteFeature(int id)
        {
            var temp = _context.Features.Find(id);
            _context.Features.Remove(temp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var temp = _context.Features.Find(id);
            return View(temp);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            _context.Features.Add(feature);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

