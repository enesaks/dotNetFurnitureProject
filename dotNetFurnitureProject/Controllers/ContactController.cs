using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Context;
using dotNetFurnitureProject.DataAccess.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly FurnitureContext _context;

        public ContactController(FurnitureContext context)
        {
            _context = context; 
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserMessage userMessage)
        {
            userMessage.MessageContent = "";
            userMessage.Subject = "";
            _context.UserMessages.Add(userMessage);
            _context.SaveChanges();
            return View();
        }
    }
}

