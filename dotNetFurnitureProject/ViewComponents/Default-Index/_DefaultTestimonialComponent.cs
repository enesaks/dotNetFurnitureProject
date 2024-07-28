using System;
using Microsoft.AspNetCore.Mvc;
using dotNetFurnitureProject.DataAccess.Context;

namespace dotNetFurnitureProject.ViewComponents.DefaultIndex
{
	public class _DefaultTestimonialComponent : ViewComponent
	{
		private readonly FurnitureContext _context;

		public _DefaultTestimonialComponent(FurnitureContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var values = _context.Testimonials.ToList();
			return View(values);

		}
	}
}

