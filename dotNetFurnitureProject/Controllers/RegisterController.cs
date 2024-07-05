using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using dotNetFurnitureProject.DataAccess.Entities;
using dotNetFurnitureProject.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetFurnitureProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        // GET: /<controller>/
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(RegisterViewModel model)
        {
            var user = new AppUser
            {
                Email = model.Email,
                UserName = model.UserName,
                NameSurname = model.NameSurname
            };

            var result = await _userManager.CreateAsync(user, model.Passaword);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.Code, item.Description);
            }

            return View();
        }
    }
}

