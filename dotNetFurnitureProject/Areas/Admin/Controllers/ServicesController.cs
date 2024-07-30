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
    public class ServicesController : Controller
    {
        private readonly FurnitureContext _context;

        public ServicesController(FurnitureContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        public IActionResult deletesServices(int id)
        {
            var temp = _context.Services.Find(id);
            _context.Services.Remove(temp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateServices(int id)
        {
            var temp = _context.Services.Find(id);
            return View(temp);
        }
        [HttpPost]
        public IActionResult UpdateServices(Service Services)
        {
            _context.Services.Update(Services);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServices(Service Services)
        {
            _context.Services.Add(Services);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

