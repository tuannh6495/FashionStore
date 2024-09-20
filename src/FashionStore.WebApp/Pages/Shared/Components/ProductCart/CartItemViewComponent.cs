using Microsoft.AspNetCore.Mvc;
using FashionStore.WebApp.Models;
using System.Collections.Generic;

namespace FashionStore.WebApp.ViewComponents
{
	public class CartItemViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(List<ProductCart> products)
		{
			// Đảm bảo rằng tên view trùng khớp với tên thư mục và file bạn đã tạo
			return View("~/Pages/Shared/Components/ProductCart/Default.cshtml", products);
		}
	}
}
