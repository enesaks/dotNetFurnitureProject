using System;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess;
using dotNetFurnitureProject.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace dotNetFurnitureProject.ViewComponents.DefaultIndex
{
	public class _DefaultServiceComponent : ViewComponent
	{

		private readonly FurnitureContext _context;

        public _DefaultServiceComponent(FurnitureContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
		{
			var values = _context.Services.ToList();
			return View(values);
		}
	}
}

