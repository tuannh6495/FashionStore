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
            if (context.Users.Any())
            {
                return;
            }
            context.Users.AddRange(
                new User { Username = "Admin", Password = "", Email = "admin@example.com", FirstName = "", LastName = "" },
                new User { Username = "User1", Password = "", Email = "user1@example.com", FirstName = "", LastName = "" }
            );
            context.SaveChanges();


            //Brand
            if (context.Brands.Any())
            {
                return;
            }
            context.Brands.AddRange(
                new Brand { Name = "Versace" },
                new Brand { Name = "Zara" },
                new Brand { Name = "Gucci" },
                new Brand { Name = "Prada" },
                new Brand { Name = "Calvin Klein" }
            );
            context.SaveChanges();


            //Cart
            if (context.Carts.Any())
            {
                return;
            }
            context.Carts.AddRange(
                new Cart { UserId = 1 }
            );
            context.SaveChanges();


            //Category
            if (context.Categories.Any())
            {
                return;
            }
            context.Categories.AddRange(
                new Category { Name = "T-shirts" },
                new Category { Name = "Shorts" },
                new Category { Name = "Shirts" },
                new Category { Name = "Hoodie" },
                new Category { Name = "Jeans" }
            );
            context.SaveChanges();


            //Gender
            if (context.Genders.Any())
            {
                return;
            }
            context.Genders.AddRange(
                new Gender { Name = "Men" },
                new Gender { Name = "Women" }
            );
            context.SaveChanges();


            //Product
            if (context.Products.Any())
            {
                return;
            }
            context.Products.AddRange(
                new Product { Name = "Gradient Graphic T-shirt", Price = 145, Description = "kszdksdo", AvgRating = 3, CategoryId = 1, GenderId = 1, BrandId = 1  }
            );
            context.SaveChanges();


            //CartP
            if (context.CartPs.Any())
            {
                return;
            }
            context.CartPs.AddRange(
                new CartP { CartId = 1, ProductId = 1, Quantity = 2, Price = 300 }
            );
            context.SaveChanges();


            //Color
            if (context.Colors.Any())
            {
                return;
            }
            context.Colors.AddRange(
                new Color { Name = "Xanh lá cây" }
            );
            context.SaveChanges();


            //ColorP
            if (context.ColorPs.Any())
            {
                return;
            }
            context.ColorPs.AddRange(
                new ColorP { ColorId = 1, ProductId = 1 }
            );
            context.SaveChanges();


            //DiscountType
            if (context.DiscountTypes.Any())
            {
                return;
            }
            context.DiscountTypes.AddRange(
                new DiscountType { Name = "Giảm giá mùa xuân" }
            );
            context.SaveChanges();


            //Discount
            if (context.Discounts.Any())
            {
                return;
            }
            context.Discounts.AddRange(
                new Discount { DiscountValue = 20, DiscountTypeId = 1, StartDate = new DateTime (2024, 8, 19), EndDate = new DateTime (2024, 12, 24) }
            );
            context.SaveChanges();


            //DiscountBrand
            if (context.DiscountBrands.Any())
            {
                return;
            }
            context.DiscountBrands.AddRange(
                new DiscountBrand { DiscountId = 1, BrandId = 1 }
            );
            context.SaveChanges();


            //DiscountProduct
            if (context.DiscountProducts.Any())
            {
                return;
            }
            context.DiscountProducts.AddRange(
                new DiscountProduct { DiscountId= 1, ProductId = 1 }
            );
            context.SaveChanges();


            //DressStyle
            if (context.DressStyles.Any())
            {
                return;
            }
            context.DressStyles.AddRange(
                new DressStyle { Name = "Casual"},
                new DressStyle { Name = "Formal" },
                new DressStyle { Name = "Party" },
                new DressStyle { Name = "Gym" }
            );
            context.SaveChanges();


            //DressStyleP
            if(context.DressStylePs.Any())
            {
                return;
            }
            context.DressStylePs.AddRange(
                new DressStyleP { DressStyleId = 1, ProductId = 1}
            );
            context.SaveChanges();


            //Outstanding
            if (context.Outstandings.Any())
            {
                return;
            }
            context.Outstandings.AddRange(
                new Outstanding { Name = "On Sale" },
                new Outstanding { Name = "New Arrivals"},
                new Outstanding { Name = "Top Selling" }
            );
            context.SaveChanges();


            //OutP
            if (context.OutPs.Any()) 
            {
                return; 
            }
            context.OutPs.AddRange(
                new OutP { OutstandingId = 2, ProductId = 1 }   
            );
            context.SaveChanges();


            //Promotion
            if (context.Promotions.Any())
            {
                return;
            }
            context.Promotions.AddRange(
                new Promotion { Name = "Giảm 20%", CartId = 1 }
            );
            context.SaveChanges();


            //Review
            if (context.Reviews.Any())
            {
                return;
            }
            context.Reviews.AddRange(
                new Review { ProductId = 1, UserId = 1, Comment = "Nice!", Rating = 4 }
            );
            context.SaveChanges();


            //Size
            if (context.Sizes.Any()) 
            { 
                return;
            }
            context.Sizes.AddRange(
                new Size { Name = "XX-Small"},
                new Size { Name = "X-Small" },
                new Size { Name = "Small" },
                new Size { Name = "Medium" },
                new Size { Name = "Large" },
                new Size { Name = "X-Large" },
                new Size { Name = "XX-Large" },
                new Size { Name = "3X-Large" },
                new Size { Name = "4X-Large" }
            );
            context.SaveChanges();


            //SizeP
            if (context.SizePs.Any())
            {
                return;
            }
            context.SizePs.AddRange(
                new SizeP { SizeId = 1, ProductId = 1 }
            );
            context.SaveChanges();


            //UserPromotion
            if (context.UserPromotions.Any())
            {
                return;
            }
            context.UserPromotions.AddRange(
                new UserPromotion { UserId = 1, PromotionId = 1 }
            );
            context.SaveChanges();
        }
    }
}
