using System;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Context;

namespace dotNetFurnitureProject.ViewComponents.DefaultIndex
{
	public class _DefaultProductComponent : ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultProductComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
            var values = _context.Products.ToList().TakeLast(3).ToList();
            return View(values);
		}
	}
}

