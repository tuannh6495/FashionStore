using Microsoft.AspNetCore.Mvc.RazorPages;
using FashionStore.WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using FashionStore.Domain.Entities;
using FashionStore.WebApp.Common;
using FashionStore.Application.DTOs;

namespace FashionStore.WebApp.Pages
{
	public class CartModel : PageModel
	{
        //public List<ProductCart> Products { get; set; }
        //public decimal Subtotal { get; set; }
        //public decimal Discount { get; set; } = 0.20m; // 20% discount
        //public decimal DeliveryFee { get; set; } = 15;
        //public decimal Total { get; set; }
        //      public decimal DiscountAmount { get; set; } // Add property for discount amount

        public List<CartPDTO> CartItems { get; set; } = new List<CartPDTO>();
        public double TotalAmount { get; set; }

        public void OnGet()
		{
            CartItems = HttpContext.Session.GetObjectFromJson<List<CartPDTO>>("Cart") ?? new List<CartPDTO>();

            TotalAmount = CartItems.Sum(item => item.TotalPrice);
            // Example products in the cart
            //Products = new List<ProductCart>
            //{
            //	new ProductCart { Name = "Gradient Graphic T-shirt", Size = "Large", Color = "White", Price = 145, Quantity = 1, ImagePath = "GradientGraphicT-shirt.png" },
            //	new ProductCart { Name = "Checkered Shirt", Size = "Medium", Color = "Red", Price = 180, Quantity = 1, ImagePath = "CHECKERED-SHIRT.png" },
            //	new ProductCart { Name = "SKINNY FIT JEANS", Size = "Large", Color = "Blue", Price = 240, Quantity = 1, ImagePath = "SKINNY-FIT-JEANS.png" }
            //};
             
            //// Calculate subtotal
            //Subtotal = Products.Sum(p => p.Price * p.Quantity);

            //         //Discount
            //         DiscountAmount = Subtotal * Discount;
            //         // Calculate total after discount and delivery fee
            //         decimal discountAmount = Subtotal * Discount;
            //Total = Subtotal - discountAmount + DeliveryFee;
        }
	}
}
