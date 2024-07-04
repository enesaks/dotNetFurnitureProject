using System;
using Microsoft.AspNetCore.Mvc;
namespace dotNetFurnitureProject.Areas.Admin.ViewComponents.AdminLayoutComponents
{
	public class _AdminSidebarComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

