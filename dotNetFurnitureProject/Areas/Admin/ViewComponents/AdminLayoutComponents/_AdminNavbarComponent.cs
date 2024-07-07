using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using dotNetFurnitureProject.DataAccess.Entities;

namespace dotNetFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
	public class _AdminNavbarComponent : ViewComponent
	{
		private readonly UserManager<AppUser> _userManager;

		public _AdminNavbarComponent(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.name = user.NameSurname;
			return View(); 
		}
	}
}

