using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using FashionStore.Domain.Entities;
using FashionStore.WebApp.Common;
using FashionStore.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using FashionStore.Application.Interfaces;

namespace FashionStore.WebApp.Pages
{
	public class CartModel : PageModel
	{
        private readonly IProductService _productService;

        public double Discount { get; set; } = 0.2; 
        public double DeliveryFee { get; set; } = 15;
        public double Total { get; set; }
        public double DiscountAmount { get; set; }

        public List<CartPDTO> CartItems { get; set; } = new List<CartPDTO>();
        public double Subtotal { get; set; }

        public CartModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
		{
            CartItems = HttpContext.Session.GetObjectFromJson<List<CartPDTO>>("Cart") ?? new List<CartPDTO>();

            Subtotal = CartItems.Sum(item => item.TotalPrice);
            DiscountAmount = Subtotal * Discount;
            Total = Subtotal - DiscountAmount + DeliveryFee;
        }

        public IActionResult OnPostRemoveItemFromCart(int productId)
        {
            var product = _productService.GetProductByIdAsync(productId);
            var cartItems = HttpContext.Session.GetObjectFromJson<List<CartPDTO>>("Cart") ?? new List<CartPDTO>();
            var productToRemove = cartItems.FirstOrDefault(p => p.ProductId == productId);
            if (productToRemove != null)
            {
                cartItems.Remove(productToRemove);
            }

            HttpContext.Session.SetObjectAsJson("Cart", cartItems);

            return RedirectToPage("Cart");
        }

    }
}
