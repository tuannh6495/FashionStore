using Microsoft.AspNetCore.Mvc;
using FashionStore.WebApp.Models;
using System.Collections.Generic;
using FashionStore.Domain.Entities;
using FashionStore.Application.DTOs;

namespace FashionStore.WebApp.ViewComponents
{
	public class CartItem : ViewComponent
	{
		public IViewComponentResult Invoke(CartPDTO item)
		{
			return View(item);
		}
	}
}
