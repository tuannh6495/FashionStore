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
                new User("Admin", "Password1", "admin@example.com", "John", "Doe"),
                new User("User1", "Password2", "user1@example.com", "Jane", "Smith"),
                new User("User2", "Password3", "user2@example.com", "Michael", "Johnson"),
                new User("User3", "Password4", "user3@example.com", "Emily", "Davis"),
                new User("User4", "Password5", "user4@example.com", "Chris", "Wilson"),
                new User("User5", "Password6", "user5@example.com", "Anna", "Taylor"),
                new User("User6", "Password7", "user6@example.com", "David", "Anderson"),
                new User("User7", "Password8", "user7@example.com", "Sophia", "Thomas"),
                new User("User8", "Password9", "user8@example.com", "Daniel", "Jackson"),
                new User("User9", "Password10", "user9@example.com", "Olivia", "White")

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
                new Product(new List<string> { "/Images/TWTD.png", "/Images/TWTD.png", "/Images/TWTD.png" }, "T-shirt With Tape Details") { Price = 120, Description = "kszdksdo", AvgRating = 4.5m, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/SFJ.png", "/Images/SFJ.png", "/Images/SFJ.png" }, "Skinny Fit Jeans") { Price = 240, Description = "oekecmk", AvgRating = 3.5m, CategoryId = 5, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/CS.png", "/Images/CS.png", "/Images/CS.png" }, "Checkered Shirt") { Price = 180, Description = "ssafeee", AvgRating = 4.5m, CategoryId = 3, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/SST.png", "/Images/SST.png", "/Images/SST.png" }, "Sleeve Striped T-shirt") { Price = 130, Description = "sass", AvgRating = 4.5m, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png" }, "Vertical Striped Shirt") { Price = 212, Description = "wiohase", AvgRating = 5, CategoryId = 3, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png" }, "Courage Graphic T-shirt") { Price = 145, Description = "dvdv", AvgRating = 4, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png" }, "Loose Fit Bermuda Shorts") { Price = 80, Description = "agrge", AvgRating = 3, CategoryId = 2, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png" }, "Faded Skinny Jeans") { Price = 210, Description = "rggr", AvgRating = 4.5m, CategoryId = 5, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/PoloWithContrastTrims.png", "/Images/PoloWithContrastTrims.png", "/Images/PoloWithContrastTrims.png" }, "Polo With Contrast Trims") { Price = 212, Description = "rtgreg", AvgRating = 4, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png" }, "Gradient Graphic T-shirt") { Price = 145, Description = "rgefdvb", AvgRating = 3.5m, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png" }, "Polo With Tipping Details") { Price = 180, Description = "dbssert", AvgRating = 4.5m, CategoryId = 1, GenderId = 1, BrandId = 1 },
                new Product(new List<string> { "/Images/BlackStripedT-shirt.png", "/Images/BlackStripedT-shirt.png", "/Images/BlackStripedT-shirt.png" }, "Black Striped T-shirt") { Price = 120, Description = "52ser5ge5er", AvgRating = 4.5m, CategoryId = 1, GenderId = 2, BrandId = 1 }
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
                new Color("Bright Green") { HexCode = "#00C12B" },
                new Color("Bright Red") { HexCode = "#F50606" },
                new Color("Bright Yellow") { HexCode = "#F5DD06" },
                new Color("Orange") { HexCode = "#F57906" },
                new Color("Sky Blue") { HexCode = "#06CAF5" },
                new Color("Deep Blue") { HexCode = "#063AF5" },
                new Color("Violet") { HexCode = "#7D06F5" },
                new Color("Hot Pink") { HexCode = "#F506A4" },
                new Color("White") { HexCode = "#FFFFFF" },
                new Color("Black") { HexCode = "#000000" }
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
            if (!context.DressStylePs.Any())
            {
                context.DressStylePs.AddRange(
                new DressStyleP { DressStyleId = 1, ProductId = 10 },
                new DressStyleP { DressStyleId = 1, ProductId = 11 },
                new DressStyleP { DressStyleId = 1, ProductId = 12 },
                new DressStyleP { DressStyleId = 1, ProductId = 2 },
                new DressStyleP { DressStyleId = 1, ProductId = 3 },
                new DressStyleP { DressStyleId = 1, ProductId = 4 },
                new DressStyleP { DressStyleId = 1, ProductId = 5 },
                new DressStyleP { DressStyleId = 1, ProductId = 6 },
                new DressStyleP { DressStyleId = 1, ProductId = 7 }
            );
                context.SaveChanges();
            }


            //Outstanding
            if (!context.Outstandings.Any())
            {
                context.Outstandings.AddRange(
                new Outstanding("On Sale"),
                new Outstanding("New Arrivals"),
                new Outstanding("Top Selling"),
                new Outstanding("You Might Also Like")
            );
                context.SaveChanges();
            }


            //OutP
            if (!context.OutPs.Any())
            {
                context.OutPs.AddRange(
                new OutP { OutstandingId = 2, ProductId = 1 },
                new OutP { OutstandingId = 2, ProductId = 2 },
                new OutP { OutstandingId = 2, ProductId = 3 },
                new OutP { OutstandingId = 2, ProductId = 4 },
                new OutP { OutstandingId = 3, ProductId = 5 },
                new OutP { OutstandingId = 3, ProductId = 6 },
                new OutP { OutstandingId = 3, ProductId = 7 },
                new OutP { OutstandingId = 3, ProductId = 8 },
                new OutP { OutstandingId = 4, ProductId = 9 },
                new OutP { OutstandingId = 4, ProductId = 10 },
                new OutP { OutstandingId = 4, ProductId = 11 },
                new OutP { OutstandingId = 4, ProductId = 12 }
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
                new Review
                {
                    ProductId = 1,
                    UserId = 2,
                    ReviewRating = 5m,
                    Comment = "I'm blown away by the quality and style of the clothes I received from Shop.co. From casual wear to elegant dresses, every piece I've bought has exceeded my expectations.",
                    DatePost = new DateTime(2023, 9, 1)
                },
                new Review
                {
                    ProductId = 2,
                    UserId = 3,
                    ReviewRating = 3m,
                    Comment = "The clothes are amazing, comfortable, and stylish. Shop.co really delivers on their promise of high-quality fashion.",
                    DatePost = new DateTime(2023, 9, 2)
                },
                new Review
                {
                    ProductId = 3,
                    UserId = 4,
                    ReviewRating = 5m,
                    Comment = "I was hesitant at first, but Shop.co completely changed my shopping experience for the better. The quality is unmatched.",
                    DatePost = new DateTime(2023, 9, 3)
                },
                new Review
                {
                    ProductId = 4,
                    UserId = 5,
                    ReviewRating = 4m,
                    Comment = "The variety of styles available is impressive, and everything I’ve bought fits perfectly. Will definitely be buying more.",
                    DatePost = new DateTime(2023, 9, 4)
                },
                new Review
                {
                    ProductId = 5,
                    UserId = 6,
                    ReviewRating = 4.5m,
                    Comment = "Shop.co provides excellent customer service and high-quality products. The attention to detail is top-notch.",
                    DatePost = new DateTime(2023, 9, 5)
                },
                new Review
                {
                    ProductId = 6,
                    UserId = 7,
                    ReviewRating = 5m,
                    Comment = "I love how versatile the clothing from Shop.co is. It’s perfect for both work and casual wear, making it a great value.",
                    DatePost = new DateTime(2023, 9, 6)
                },
                new Review
                {
                    ProductId = 7,
                    UserId = 8,
                    ReviewRating = 4.5m,
                    Comment = "The material is so soft and comfortable, yet durable. These clothes feel like they’ll last me a long time.",
                    DatePost = new DateTime(2023, 9, 7)
                },
                new Review
                {
                    ProductId = 8,
                    UserId = 9,
                    ReviewRating = 4m,
                    Comment = "The fashion options from Shop.co are exactly what I’ve been looking for. The designs are trendy and flattering.",
                    DatePost = new DateTime(2023, 9, 8)
                },
                new Review
                {
                    ProductId = 9,
                    UserId = 10,
                    ReviewRating = 3m,
                    Comment = "I’ve never had clothes fit so well right out of the box. The sizing is perfect, and the quality is excellent.",
                    DatePost = new DateTime(2023, 9, 9)
                },
                new Review
                {
                    ProductId = 10,
                    UserId = 2,
                    ReviewRating = 4.5m,
                    Comment = "Shop.co’s clothes have become my new wardrobe staples. They go with everything, and I get compliments all the time.",
                    DatePost = new DateTime(2023, 9, 10)
                },
                new Review
                {
                    ProductId = 11,
                    UserId = 3,
                    ReviewRating = 4m,
                    Comment = "The customer service is great, and the clothes always arrive on time and in perfect condition. I’m a loyal customer now.",
                    DatePost = new DateTime(2023, 9, 11)
                },
                new Review
                {
                    ProductId = 12,
                    UserId = 4,
                    ReviewRating = 5m,
                    Comment = "The quality of the fabric is superior to anything I’ve bought before. These clothes hold up really well after washing.",
                    DatePost = new DateTime(2023, 9, 12)
                },
                new Review
                {
                    ProductId = 1,
                    UserId = 5,
                    ReviewRating = 4.5m,
                    Comment = "Shop.co’s attention to detail is what sets them apart from other fashion brands. Every item is well-made.",
                    DatePost = new DateTime(2023, 9, 13)
                },
                new Review
                {
                    ProductId = 2,
                    UserId = 6,
                    ReviewRating = 4m,
                    Comment = "I appreciate how environmentally friendly the materials are, without compromising on style or quality.",
                    DatePost = new DateTime(2023, 9, 14)
                },
                new Review
                {
                    ProductId = 3,
                    UserId = 7,
                    ReviewRating = 5m,
                    Comment = "I always get compliments when I wear something from Shop.co. Their pieces are stylish, modern, and well-crafted.",
                    DatePost = new DateTime(2023, 9, 15)
                },
                new Review
                {
                    ProductId = 4,
                    UserId = 8,
                    ReviewRating = 3.5m,
                    Comment = "The clothes are true to size and incredibly comfortable. I’m very happy with everything I’ve purchased so far.",
                    DatePost = new DateTime(2023, 9, 16)
                },
                new Review
                {
                    ProductId = 5,
                    UserId = 9,
                    ReviewRating = 4m,
                    Comment = "The delivery was quick, and the packaging was secure. The clothes were even better than I expected.",
                    DatePost = new DateTime(2023, 9, 17)
                },
                new Review
                {
                    ProductId = 6,
                    UserId = 10,
                    ReviewRating = 4.5m,
                    Comment = "I love the variety of styles Shop.co offers. There’s something for every occasion, and the quality is top-notch.",
                    DatePost = new DateTime(2023, 9, 18)
                },
                new Review
                {
                    ProductId = 7,
                    UserId = 2,
                    ReviewRating = 5m,
                    Comment = "I was skeptical at first, but after my first purchase, I’m completely sold on Shop.co. The clothes are amazing.",
                    DatePost = new DateTime(2023, 9, 19)
                },
                new Review
                {
                    ProductId = 8,
                    UserId = 3,
                    ReviewRating = 4.5m,
                    Comment = "The fit and feel of these clothes are perfect. I love how they look, and I feel great wearing them.",
                    DatePost = new DateTime(2023, 9, 20)
                }
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
