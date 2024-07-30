using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    [Authorize]
    public class MessagesController : Controller
    {
        FurnitureContext _context;

        public MessagesController(FurnitureContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var temp = _context.UserMessages.ToList();
            return View(temp);
        }

        public IActionResult deletesMessages(int id)
        {
            var temp = _context.UserMessages.Find(id);
            _context.UserMessages.Remove(temp);
            return RedirectToAction("Index");
        }
    }
}

