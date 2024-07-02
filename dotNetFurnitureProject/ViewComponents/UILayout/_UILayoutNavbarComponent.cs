using System;
using Microsoft.AspNetCore.Mvc;
namespace dotNetFurnitureProject.ViewComponents.UILayout
{
	public class _UILayoutNavbarComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

