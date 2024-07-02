using System;
using Microsoft.AspNetCore.Mvc;

namespace dotNetFurnitureProject.ViewComponents.UILayout
{
	public class _UILayoutFooterComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

