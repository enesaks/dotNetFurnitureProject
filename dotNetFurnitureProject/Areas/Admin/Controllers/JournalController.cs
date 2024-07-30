using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Context;
using dotNetFurnitureProject.DataAccess.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class JournalController : Controller
    {
        FurnitureContext _context;

        public JournalController(FurnitureContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var temp = _context.Journals.ToList();
            return View(temp);
        }

        public IActionResult deletesJournal(int id)
        {
            var temp = _context.Journals.Find(id);
            _context.Journals.Remove(temp);
            return RedirectToAction("Index");
        }
    }
}

