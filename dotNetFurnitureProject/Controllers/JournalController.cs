using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetFurnitureProject.DataAccess.Context;
using dotNetFurnitureProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Controllers
{
    public class JournalController : Controller
    {
        private readonly FurnitureContext _context;

        public JournalController(FurnitureContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Journal journal)
        {
            if (journal != null)
            {
                _context.Journals.Add(journal);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Default"); 
        }
    }
}

