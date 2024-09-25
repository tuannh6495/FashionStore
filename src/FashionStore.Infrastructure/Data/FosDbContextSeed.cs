using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Data
{
    public static class FosDbContextSeed
    {
        public static void Seed(FosDbContext context)
        {
            //User
            context.Database.Migrate();
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                new User("Admin", "", "admin@example.com", "", ""),
                new User("Admin", "", "user1@example.com", "", "")
            );
                context.SaveChanges();
            }
            

            //Brand
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(
                new Brand("Versace"),
                new Brand("Zara"),
                new Brand("Gucci"),
                new Brand("Prada"),
                new Brand("Calvin Klein")
            );
                context.SaveChanges();
            }
            

            //Cart
            if (!context.Carts.Any())
            {
                context.Carts.AddRange(
                new Cart { UserId = 1 }
            );
                context.SaveChanges();
            }
            

            //Category
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                new Category("T-shirts"),
                new Category("Shorts"),
                new Category("Shirts"),
                new Category("Hoodie"),
                new Category("Jeans")
            );
                context.SaveChanges();
            }
            

            //Gender
            if (!context.Genders.Any())
            {
                context.Genders.AddRange(
                new Gender("Men"),
                new Gender("Women")
            );
                context.SaveChanges();
            }


            //Product
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product(new List<string> { "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png" }, "Gradient Graphic T-shirt") { Price = 145, Description = "kszdksdo", AvgRating = 3, CategoryId = 1, GenderId = 1, BrandId = 1 }
            );
                context.SaveChanges();
            }
            

            //CartP
            if (!context.CartPs.Any())
            {
                context.CartPs.AddRange(
                new CartP { CartId = 1, ProductId = 1, Quantity = 2, Price = 300 }
            );
                context.SaveChanges();
            }
            

            //Color
            if (!context.Colors.Any())
            {
                context.Colors.AddRange(
                new Color("Xanh lá cây")
            );
                context.SaveChanges();
            }
            

            //ColorP
            if (!context.ColorPs.Any())
            {
                context.ColorPs.AddRange(
                new ColorP { ColorId = 1, ProductId = 1 }
            );
                context.SaveChanges();
            }


            //DiscountType
            if (!context.DiscountTypes.Any())
            {
                context.DiscountTypes.AddRange(
                new DiscountType("Giảm giá mùa xuân")
            );
                context.SaveChanges();
            }


            //Discount
            if (!context.Discounts.Any())
            {
                context.Discounts.AddRange(
                new Discount { DiscountValue = 20, DiscountTypeId = 1, StartDate = new DateTime(2024, 8, 19), EndDate = new DateTime(2024, 12, 24) }
            );
                context.SaveChanges();
            }


            //DiscountBrand
            if (!context.DiscountBrands.Any())
            {
                context.DiscountBrands.AddRange(
                new DiscountBrand { DiscountId = 1, BrandId = 1 }
            );
                context.SaveChanges();
            }


            //DiscountProduct
            if (!context.DiscountProducts.Any())
            {
                context.DiscountProducts.AddRange(
                new DiscountProduct { DiscountId = 1, ProductId = 1 }
            );
                context.SaveChanges();
            }


            //DressStyle
            if (!context.DressStyles.Any())
            {
                context.DressStyles.AddRange(
                new DressStyle("Casual"),
                new DressStyle("Formal"),
                new DressStyle("Party"),
                new DressStyle("Gym")
            );
                context.SaveChanges();
            }


            //DressStyleP
            if(!context.DressStylePs.Any())
            {
                context.DressStylePs.AddRange(
                new DressStyleP { DressStyleId = 1, ProductId = 1 }
            );
                context.SaveChanges();
            }


            //Outstanding
            if (!context.Outstandings.Any())
            {
                context.Outstandings.AddRange(
                new Outstanding("On Sale"),
                new Outstanding("New Arrivals"),
                new Outstanding("Top Selling")
            );
                context.SaveChanges();
            }
            

            //OutP
            if (!context.OutPs.Any()) 
            {
                context.OutPs.AddRange(
                new OutP { OutstandingId = 2, ProductId = 1 }
            );
                context.SaveChanges();
            }
            

            //Promotion
            if (!context.Promotions.Any())
            {
                context.Promotions.AddRange(
                new Promotion("Giảm 20%") { CartId = 1 }
            );
                context.SaveChanges();
            }


            //Review
            if (!context.Reviews.Any())
            {
                context.Reviews.AddRange(
                new Review { ProductId = 1, UserId = 1, Comment = "Nice!", ReviewRating = 4m }
            );
                context.SaveChanges();
            }
            

            //Size
            if (!context.Sizes.Any()) 
            {
                context.Sizes.AddRange(
                new Size("XX-Small"),
                new Size("X-Small"),
                new Size("Small"),
                new Size("Medium"),
                new Size("Large"),
                new Size("X-Large"),
                new Size("XX-Large"),
                new Size("3X-Large"),
                new Size("4X-Large")
            );
                context.SaveChanges();
            }


            //SizeP
            if (!context.SizePs.Any())
            {
                context.SizePs.AddRange(
                new SizeP { SizeId = 1, ProductId = 1 }
            );
                context.SaveChanges();
            }


            //UserPromotion
            if (!context.UserPromotions.Any())
            {
                context.UserPromotions.AddRange(
                new UserPromotion { UserId = 1, PromotionId = 1 }
            );
                context.SaveChanges();
            }
        }
    }
}
