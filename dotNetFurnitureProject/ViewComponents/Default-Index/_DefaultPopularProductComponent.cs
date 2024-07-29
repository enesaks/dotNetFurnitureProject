using System;
using dotNetFurnitureProject.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace dotNetFurnitureProject.ViewComponents.DefaultIndex
{
	public class _DefaultPopularProductComponent : ViewComponent
	{
        private readonly FurnitureContext _context;

        public _DefaultPopularProductComponent(FurnitureContext context)
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

