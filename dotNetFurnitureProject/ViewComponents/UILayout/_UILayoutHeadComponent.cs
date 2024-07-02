using System;
using Microsoft.AspNetCore.Mvc;
namespace dotNetFurnitureProject.ViewComponents
{
	public class _UILayoutHeadComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

