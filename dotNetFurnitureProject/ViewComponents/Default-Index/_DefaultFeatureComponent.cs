using System;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Context;
namespace dotNetFurnitureProject.ViewComponents.DefaultIndex
{
	public class _DefaultFeatureComponent : ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultFeatureComponent(FurnitureContext context)
		{
			 _context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values = _context.Features.ToList();
			return View(values);
		}
	}
}

