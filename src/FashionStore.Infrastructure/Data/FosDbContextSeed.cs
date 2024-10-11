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
            context.Database.Migrate();

            //User
            var users = new List<User>
            {
                new User("Admin", "Password1", "admin@example.com", "John", "Doe"),
                new User("User1", "Password2", "user1@example.com", "Jane", "Smith"),
                new User("User2", "Password3", "user2@example.com", "Michael", "Johnson"),
                new User("User3", "Password4", "user3@example.com", "Emily", "Davis"),
                new User("User4", "Password5", "user4@example.com", "Chris", "Wilson"),
                new User("User5", "Password6", "user5@example.com", "Anna", "Taylor"),
                new User("User6", "Password7", "user6@example.com", "David", "Anderson"),
                new User("User7", "Password8", "user7@example.com", "Sophia", "Thomas"),
                new User("User8", "Password9", "user8@example.com", "Daniel", "Jackson"),
                new User("User9", "Password10", "user9@example.com", "Olivia", "White"),
                new User("User10", "Password11", "user10@example.com", "Liam", "Walker"),
                new User("User11", "Password12", "user11@example.com", "Sophia", "Martinez"),
                new User("User12", "Password13", "user12@example.com", "James", "Hernandez"),
                new User("User13", "Password14", "user13@example.com", "Isabella", "Robinson"),
                new User("User14", "Password15", "user14@example.com", "Benjamin", "Clark"),
                new User("User15", "Password16", "user15@example.com", "Mia", "Lewis"),
                new User("User16", "Password17", "user16@example.com", "Lucas", "Young"),
                new User("User17", "Password18", "user17@example.com", "Charlotte", "King"),
                new User("User18", "Password19", "user18@example.com", "Henry", "Scott"),
                new User("User19", "Password20", "user19@example.com", "Ava", "Green"),
                new User("User20", "Password21", "user20@example.com", "William", "Baker")
            };

            var newUsers = users.Where(u => !context.Users.Any(dbUser => dbUser.Username == u.Username)).ToList();
            if (newUsers.Any())
            {
                context.Users.AddRange(newUsers);
                context.SaveChanges();
            }



            //Brand
            var brands = new List<Brand>
            {
                new Brand("Versace"),
                new Brand("Zara"),
                new Brand("Gucci"),
                new Brand("Prada"),
                new Brand("Calvin Klein"),
                new Brand("H&M"),
                new Brand("Uniqlo")
            };

            var newBrands = brands.Where(b => !context.Brands.Any(dbBrand => dbBrand.Name == b.Name)).ToList();
            if (newBrands.Any())
            {
                context.Brands.AddRange(newBrands);
                context.SaveChanges();
            }



            // Cart
            var carts = new List<Cart>
            {
                new Cart { UserId = 1 },
                new Cart { UserId = 2 },
                new Cart { UserId = 3 },
                new Cart { UserId = 4 }
            };

            var newCarts = carts.Where(c => !context.Carts.Any(dbCart => dbCart.UserId == c.UserId)).ToList();
            if (newCarts.Any())
            {
                context.Carts.AddRange(newCarts);
                context.SaveChanges();
            }



            // Category
            var categories = new List<Category>
            {
                new Category("T-shirts"),
                new Category("Shorts"),
                new Category("Shirts"),
                new Category("Hoodie"),
                new Category("Jeans"),
            };

            var newCategories = categories.Where(c => !context.Categories.Any(dbCategory => dbCategory.Name == c.Name)).ToList();
            if (newCategories.Any())
            {
                context.Categories.AddRange(newCategories);
                context.SaveChanges();
            }



            // Gender
            var genders = new List<Gender>
            {
                new Gender("Men"),
                new Gender("Women"),
                new Gender("Unisex")
            };

            var newGenders = genders.Where(g => !context.Genders.Any(dbGender => dbGender.Name == g.Name)).ToList();
            if (newGenders.Any())
            {
                context.Genders.AddRange(newGenders);
                context.SaveChanges();
            }



			// DiscountType
			var discountTypes = new List<DiscountType>
			{
				new DiscountType("Spring Sale"),
				new DiscountType("Black Friday Discount"),
				new DiscountType("Summer Sale"),
				new DiscountType("Christmas Sale"),
				new DiscountType("Weekend Flash Sale"),
				new DiscountType("Birthday Discount"),
				new DiscountType("Office Fashion Discount"),
				new DiscountType("Grand Opening Discount"),
				new DiscountType("End of Season Clearance"),
				new DiscountType("Mid-Year Sale"),
				new DiscountType("Back to School Sale"),
				new DiscountType("New Collection Launch Discount"),
				new DiscountType("Cyber Monday Discount"),
				new DiscountType("Holiday Season Sale"),
			};

			var newDiscountTypes = discountTypes.Where(dt => !context.DiscountTypes.Any(dbDiscountType => dbDiscountType.Name == dt.Name)).ToList();
			if (newDiscountTypes.Any())
			{
				context.DiscountTypes.AddRange(newDiscountTypes);
				context.SaveChanges();
			}



			// Discount
			var discounts = new List<Discount>
			{
				new Discount { DiscountValue = 20, DiscountTypeId = 1, StartDate = new DateTime(2024, 8, 19), EndDate = new DateTime(2024, 12, 24) },
				new Discount { DiscountValue = 25, DiscountTypeId = 1, StartDate = new DateTime(2024, 1, 4), EndDate = new DateTime(2024, 7, 2) },
				new Discount { DiscountValue = 40, DiscountTypeId = 1, StartDate = new DateTime(2024, 11, 19), EndDate = new DateTime(2025, 3, 3) },
				new Discount { DiscountValue = 45, DiscountTypeId = 1, StartDate = new DateTime(2024, 4, 12), EndDate = new DateTime(2024, 4, 29) },
				new Discount { DiscountValue = 50, DiscountTypeId = 1, StartDate = new DateTime(2024, 5, 23), EndDate = new DateTime(2024, 10, 26) },
				new Discount { DiscountValue = 14, DiscountTypeId = 1, StartDate = new DateTime(2024, 12, 4), EndDate = new DateTime(2025, 1, 21) },
				new Discount { DiscountValue = 65, DiscountTypeId = 2, StartDate = new DateTime(2024, 4, 16), EndDate = new DateTime(2024, 7, 1) },
				new Discount { DiscountValue = 30, DiscountTypeId = 2, StartDate = new DateTime(2024, 12, 21), EndDate = new DateTime(2025, 3, 31) },
				new Discount { DiscountValue = 20, DiscountTypeId = 2, StartDate = new DateTime(2024, 1, 13), EndDate = new DateTime(2024, 5, 16) },
				new Discount { DiscountValue = 25, DiscountTypeId = 2, StartDate = new DateTime(2024, 5, 14), EndDate = new DateTime(2024, 10, 8) },
				new Discount { DiscountValue = 34, DiscountTypeId = 2, StartDate = new DateTime(2024, 9, 18), EndDate = new DateTime(2024, 11, 5) },
				new Discount { DiscountValue = 28, DiscountTypeId = 2, StartDate = new DateTime(2024, 4, 9), EndDate = new DateTime(2024, 6, 20) },
				new Discount { DiscountValue = 45, DiscountTypeId = 2, StartDate = new DateTime(2024, 4, 6), EndDate = new DateTime(2024, 6, 1) },
				new Discount { DiscountValue = 10, DiscountTypeId = 3, StartDate = new DateTime(2024, 12, 12), EndDate = new DateTime(2025, 3, 21) },
				new Discount { DiscountValue = 20, DiscountTypeId = 3, StartDate = new DateTime(2024, 3, 19), EndDate = new DateTime(2024, 7, 15) },
				new Discount { DiscountValue = 16, DiscountTypeId = 3, StartDate = new DateTime(2024, 3, 14), EndDate = new DateTime(2024, 6, 27) },
				new Discount { DiscountValue = 47, DiscountTypeId = 3, StartDate = new DateTime(2024, 1, 19), EndDate = new DateTime(2024, 3, 23) },
				new Discount { DiscountValue = 10, DiscountTypeId = 4, StartDate = new DateTime(2024, 11, 20), EndDate = new DateTime(2025, 1, 4) },
				new Discount { DiscountValue = 65, DiscountTypeId = 4, StartDate = new DateTime(2024, 1, 28), EndDate = new DateTime(2024, 2, 16) },
				new Discount { DiscountValue = 25, DiscountTypeId = 4, StartDate = new DateTime(2024, 9, 2), EndDate = new DateTime(2024, 10, 11) },
				new Discount { DiscountValue = 45, DiscountTypeId = 4, StartDate = new DateTime(2024, 4, 20), EndDate = new DateTime(2024, 6, 19) },
				new Discount { DiscountValue = 7, DiscountTypeId = 4, StartDate = new DateTime(2024, 6, 5), EndDate = new DateTime(2024, 6, 26) },
				new Discount { DiscountValue = 17, DiscountTypeId = 4, StartDate = new DateTime(2024, 6, 28), EndDate = new DateTime(2024, 10, 30) },
				new Discount { DiscountValue = 28, DiscountTypeId = 4, StartDate = new DateTime(2024, 11, 7), EndDate = new DateTime(2024, 12, 21) },
				new Discount { DiscountValue = 35, DiscountTypeId = 5, StartDate = new DateTime(2024, 2, 22), EndDate = new DateTime(2024, 3, 15) },
				new Discount { DiscountValue = 45, DiscountTypeId = 5, StartDate = new DateTime(2024, 10, 20), EndDate = new DateTime(2024, 12, 13) },
				new Discount { DiscountValue = 65, DiscountTypeId = 5, StartDate = new DateTime(2024, 8, 8), EndDate = new DateTime(2024, 11, 2) },
				new Discount { DiscountValue = 25, DiscountTypeId = 5, StartDate = new DateTime(2024, 12, 25), EndDate = new DateTime(2025, 3, 3) },
				new Discount { DiscountValue = 28, DiscountTypeId = 5, StartDate = new DateTime(2024, 8, 12), EndDate = new DateTime(2024, 10, 2) },
				new Discount { DiscountValue = 36, DiscountTypeId = 5, StartDate = new DateTime(2024, 1, 5), EndDate = new DateTime(2024, 2, 2) },
				new Discount { DiscountValue = 40, DiscountTypeId = 6, StartDate = new DateTime(2024, 12, 18), EndDate = new DateTime(2025, 5, 25) },
				new Discount { DiscountValue = 45, DiscountTypeId = 6, StartDate = new DateTime(2024, 9, 6), EndDate = new DateTime(2025, 1, 25) },
				new Discount { DiscountValue = 20, DiscountTypeId = 6, StartDate = new DateTime(2024, 6, 24), EndDate = new DateTime(2024, 11, 12) },
				new Discount { DiscountValue = 26, DiscountTypeId = 6, StartDate = new DateTime(2024, 5, 4), EndDate = new DateTime(2024, 6, 4) },
				new Discount { DiscountValue = 34, DiscountTypeId = 6, StartDate = new DateTime(2024, 2, 15), EndDate = new DateTime(2024, 5, 4) },
				new Discount { DiscountValue = 25, DiscountTypeId = 7, StartDate = new DateTime(2024, 6, 7), EndDate = new DateTime(2024, 8, 28) },
				new Discount { DiscountValue = 30, DiscountTypeId = 7, StartDate = new DateTime(2024, 10, 13), EndDate = new DateTime(2024, 12, 19) },
				new Discount { DiscountValue = 45, DiscountTypeId = 7, StartDate = new DateTime(2024, 6, 12), EndDate = new DateTime(2024, 11, 2) },
				new Discount { DiscountValue = 21, DiscountTypeId = 7, StartDate = new DateTime(2024, 10, 13), EndDate = new DateTime(2025, 3, 22) },
				new Discount { DiscountValue = 55, DiscountTypeId = 8, StartDate = new DateTime(2024, 11, 2), EndDate = new DateTime(2024, 12, 2) },
				new Discount { DiscountValue = 65, DiscountTypeId = 8, StartDate = new DateTime(2024, 7, 18), EndDate = new DateTime(2024, 9, 10) },
				new Discount { DiscountValue = 60, DiscountTypeId = 8, StartDate = new DateTime(2024, 12, 1), EndDate = new DateTime(2025, 2, 28) },
				new Discount { DiscountValue = 30, DiscountTypeId = 8, StartDate = new DateTime(2024, 6, 15), EndDate = new DateTime(2024, 6, 25) },
				new Discount { DiscountValue = 37, DiscountTypeId = 8, StartDate = new DateTime(2024, 1, 27), EndDate = new DateTime(2024, 2, 15) },
				new Discount { DiscountValue = 36, DiscountTypeId = 8, StartDate = new DateTime(2024, 6, 3), EndDate = new DateTime(2024, 6, 18) },
				new Discount { DiscountValue = 20, DiscountTypeId = 9, StartDate = new DateTime(2024, 1, 17), EndDate = new DateTime(2024, 4, 14) },
				new Discount { DiscountValue = 50, DiscountTypeId = 9, StartDate = new DateTime(2024, 11, 5), EndDate = new DateTime(2024, 12, 29) },
				new Discount { DiscountValue = 18, DiscountTypeId = 9, StartDate = new DateTime(2024, 10, 9), EndDate = new DateTime(2025, 1, 21) },
				new Discount { DiscountValue = 13, DiscountTypeId = 9, StartDate = new DateTime(2024, 10, 17), EndDate = new DateTime(2024, 12, 1) },
				new Discount { DiscountValue = 10, DiscountTypeId = 10, StartDate = new DateTime(2024, 11, 6), EndDate = new DateTime(2024, 12, 23) },
				new Discount { DiscountValue = 60, DiscountTypeId = 10, StartDate = new DateTime(2024, 10, 1), EndDate = new DateTime(2024, 11, 6) },
				new Discount { DiscountValue = 25, DiscountTypeId = 10, StartDate = new DateTime(2024, 10, 3), EndDate = new DateTime(2025, 1, 13) },
				new Discount { DiscountValue = 15, DiscountTypeId = 10, StartDate = new DateTime(2024, 10, 1), EndDate = new DateTime(2024, 12, 11) },
				new Discount { DiscountValue = 34, DiscountTypeId = 10, StartDate = new DateTime(2024, 8, 14), EndDate = new DateTime(2025, 1, 13) },
				new Discount { DiscountValue = 48, DiscountTypeId = 10, StartDate = new DateTime(2024, 5, 10), EndDate = new DateTime(2024, 8, 4) },
				new Discount { DiscountValue = 25, DiscountTypeId = 11, StartDate = new DateTime(2024, 6, 3), EndDate = new DateTime(2024, 6, 24) },
				new Discount { DiscountValue = 40, DiscountTypeId = 11, StartDate = new DateTime(2024, 7, 12), EndDate = new DateTime(2024, 8, 30) },
				new Discount { DiscountValue = 15, DiscountTypeId = 11, StartDate = new DateTime(2024, 6, 15), EndDate = new DateTime(2024, 11, 18) },
				new Discount { DiscountValue = 19, DiscountTypeId = 11, StartDate = new DateTime(2024, 1, 26), EndDate = new DateTime(2024, 4, 2) },
				new Discount { DiscountValue = 14, DiscountTypeId = 11, StartDate = new DateTime(2024, 4, 18), EndDate = new DateTime(2024, 9, 14) },
				new Discount { DiscountValue = 15, DiscountTypeId = 12, StartDate = new DateTime(2024, 1, 20), EndDate = new DateTime(2024, 6, 17) },
				new Discount { DiscountValue = 20, DiscountTypeId = 12, StartDate = new DateTime(2024, 1, 19), EndDate = new DateTime(2024, 6, 29) },
				new Discount { DiscountValue = 19, DiscountTypeId = 12, StartDate = new DateTime(2024, 5, 9), EndDate = new DateTime(2024, 9, 20) },
				new Discount { DiscountValue = 6, DiscountTypeId = 12, StartDate = new DateTime(2024, 6, 5), EndDate = new DateTime(2024, 11, 27) },
				new Discount { DiscountValue = 60, DiscountTypeId = 13, StartDate = new DateTime(2024, 5, 8), EndDate = new DateTime(2024, 7, 11) },
				new Discount { DiscountValue = 20, DiscountTypeId = 13, StartDate = new DateTime(2024, 8, 25), EndDate = new DateTime(2024, 9, 14) },
				new Discount { DiscountValue = 45, DiscountTypeId = 13, StartDate = new DateTime(2024, 6, 10), EndDate = new DateTime(2024, 7, 8) },
				new Discount { DiscountValue = 15, DiscountTypeId = 13, StartDate = new DateTime(2024, 8, 5), EndDate = new DateTime(2024, 10, 1) },
				new Discount { DiscountValue = 12, DiscountTypeId = 13, StartDate = new DateTime(2024, 10, 13), EndDate = new DateTime(2025, 2, 9) },
				new Discount { DiscountValue = 8, DiscountTypeId = 13, StartDate = new DateTime(2024, 11, 27), EndDate = new DateTime(2024, 12, 7) },
				new Discount { DiscountValue = 15, DiscountTypeId = 14, StartDate = new DateTime(2024, 2, 8), EndDate = new DateTime(2024, 4, 22) },
				new Discount { DiscountValue = 50, DiscountTypeId = 14, StartDate = new DateTime(2024, 10, 2), EndDate = new DateTime(2025, 1, 2) },
				new Discount { DiscountValue = 20, DiscountTypeId = 14, StartDate = new DateTime(2024, 12, 24), EndDate = new DateTime(2025, 1, 26) },
				new Discount { DiscountValue = 25, DiscountTypeId = 14, StartDate = new DateTime(2024, 7, 19), EndDate = new DateTime(2025, 1, 1) },
				new Discount { DiscountValue = 24, DiscountTypeId = 14, StartDate = new DateTime(2024, 3, 25), EndDate = new DateTime(2024, 8, 21) },
				new Discount { DiscountValue = 48, DiscountTypeId = 14, StartDate = new DateTime(2024, 9, 28), EndDate = new DateTime(2024, 11, 18) },
				new Discount { DiscountValue = 18, DiscountTypeId = 14, StartDate = new DateTime(2024, 2, 8), EndDate = new DateTime(2024, 4, 17) }
			};

			var newDiscounts = discounts.Where(d => !context.Discounts.Any(dbDiscount => dbDiscount.DiscountValue == d.DiscountValue && dbDiscount.DiscountTypeId == d.DiscountTypeId)).ToList();
			if (newDiscounts.Any())
			{
				context.Discounts.AddRange(newDiscounts);
				context.SaveChanges();
			}



			// Product
			var products = new List<Product>
            {
                new Product(new List<string> { "/Images/TWTD.png", "/Images/TWTD.png", "/Images/TWTD.png" }, "T-shirt With Tape Details")
                {
                    Price = 120,
                    Description = "Elevate your casual style with this t-shirt featuring sleek tape details. Made from soft, breathable fabric, it offers all-day comfort and a modern, street-ready vibe for any occasion.",
                    AvgRating = 4.5m,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
                    DiscountId = 2
                },

                new Product(new List<string> { "/Images/SFJ.png", "/Images/SFJ.png", "/Images/SFJ.png" }, "Skinny Fit Jeans")
                {
                    Price = 240,
                    Description = "These skinny fit jeans are designed to highlight your silhouette with a trendy, slim fit. Crafted from high-quality, stretch fabric, they provide both comfort and style, perfect for everything from casual outings to nights out.",
                    AvgRating = 3.5m,
                    CategoryId = 5,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 7
				},

                new Product(new List<string> { "/Images/CS.png", "/Images/CS.png", "/Images/CS.png" }, "Checkered Shirt")
                {
                    Price = 180,
                    Description = "This checkered shirt is a timeless classic reimagined for modern fashion. Its lightweight, breathable fabric ensures all-day comfort, making it ideal for work, social events, or casual weekends.",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 1
				},

                new Product(new List<string> { "/Images/SST.png", "/Images/SST.png", "/Images/SST.png" }, "Sleeve Striped T-shirt")
                {
                    Price = 130,
                    Description = "This striped sleeve t-shirt brings a fresh twist to your casual wardrobe. Crafted from soft, breathable fabric, it's a go-to choice for effortless style, whether you're pairing it with jeans or layering it under a jacket.",
                    AvgRating = 4.5m,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 16
				},

                new Product(new List<string> { "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png" }, "Vertical Striped Shirt")
                {
                    Price = 212,
                    Description = "With its vertical stripes, this shirt is the perfect blend of smart and stylish. Made from premium fabric, it offers both comfort and a refined look that works well for both casual and more polished outfits.",
                    AvgRating = 5,
                    CategoryId = 3,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 20
				},

                new Product(new List<string> { "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png" }, "Courage Graphic T-shirt")
                {
                    Price = 145,
                    Description = "Make a bold statement with this Courage graphic t-shirt. The soft, breathable fabric ensures all-day comfort, while the striking design lets you showcase your personality with ease.",
                    AvgRating = 4,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 9
				},

                new Product(new List<string> { "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png" }, "Loose Fit Bermuda Shorts")
                {
                    Price = 80,
                    Description = "Stay cool and casual in these loose fit Bermuda shorts. Designed for maximum comfort with a relaxed fit, they're perfect for warm days and laid-back outings.",
                    AvgRating = 3,
                    CategoryId = 2,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 22
				},

                new Product(new List<string> { "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png" }, "Faded Skinny Jeans")
                {
                    Price = 210,
                    Description = "These faded skinny jeans offer a trendy, worn-in look that never goes out of style. The stretchy, durable fabric moves with you, making them a must-have for any casual or stylish occasion.",
                    AvgRating = 4.5m,
                    CategoryId = 5,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 14
				},

                new Product(new List<string> { "/Images/PoloWithContrastTrims.png", "/Images/PoloWithContrastTrims.png", "/Images/PoloWithContrastTrims.png" }, "Polo With Contrast Trims")
                {
                    Price = 212,
                    Description = "This polo shirt with contrast trims adds a touch of sophistication to a classic design. Crafted from soft, breathable fabric, it’s perfect for both casual Fridays and weekend outings.",
                    AvgRating = 4,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 18
				},

                new Product(new List<string> { "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png" }, "Gradient Graphic T-shirt")
                {
                    Price = 145,
                    Description = "Stand out from the crowd with this gradient graphic t-shirt. Its unique design and lightweight fabric provide the perfect combination of comfort and style for your everyday adventures.",
                    AvgRating = 3.5m,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 8
				},

                new Product(new List<string> { "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png" }, "Polo With Tipping Details")
                {
                    Price = 180,
                    Description = "Refined yet relaxed, this polo shirt with tipping details brings subtle flair to your wardrobe. The breathable material ensures comfort, while the stylish accents elevate your everyday look.",
                    AvgRating = 4.5m,
                    CategoryId = 1,
                    GenderId = 1,
                    BrandId = 1,
					DiscountId = 11
				},

                new Product(new List<string> { "/Images/BlackStripedT-shirt.png", "/Images/BlackStripedT-shirt.png", "/Images/BlackStripedT-shirt.png" }, "Black Striped T-shirt")
                {
                    Price = 120,
                    Description = "Simple yet striking, this black striped t-shirt is a wardrobe essential. Its soft, breathable fabric ensures you stay comfortable while looking effortlessly cool.",
                    AvgRating = 4.5m,
                    CategoryId = 1,
                    GenderId = 2,
                    BrandId = 1,
					DiscountId = 5
				},

                new Product(new List<string> { "/Images/T-shirts/Asymmetric Ribbed T-shirt/fore.webp", "/Images/T-shirts/Asymmetric Ribbed T-shirt/back.webp", "/Images/T-shirts/Asymmetric Ribbed T-shirt/model.webp" }, "Asymmetric Ribbed T-shirt")
                {
                    Price = 120,
                    Description = "Simple yet striking, this black striped t-shirt is a wardrobe essential. Its soft, breathable fabric ensures you stay comfortable while looking effortlessly cool.",
                    AvgRating = 4.5m,
                    CategoryId = 1,
                    GenderId = 2,
                    BrandId = 1,
                    DiscountId = 5
                },


				new Product(new List<string> { "/Images/T-shirts/Monogram Logo Overlay Graphic Classic T-shirt/back.webp", "/Images/T-shirts/Monogram Logo Overlay Graphic Classic T-shirt/fore.webp", "/Images/T-shirts/Monogram Logo Overlay Graphic Classic T-shirt/model.webp" }, "Monogram Logo Overlay Graphic Classic T-shirt")
				{
					Price = 120,
					Description = "Simple yet striking, this black striped t-shirt is a wardrobe essential. Its soft, breathable fabric ensures you stay comfortable while looking effortlessly cool.",
					AvgRating = 4.5m,
					CategoryId = 1,
					GenderId = 2,
					BrandId = 1,
					DiscountId = 5
				}
			};

            var newProducts = products.Where(p => !context.Products.Any(dbProduct => dbProduct.Name == p.Name)).ToList();
            if (newProducts.Any())
            {
                context.Products.AddRange(newProducts);
                context.SaveChanges();
            }



            // CartP
            var cartPs = new List<CartP>
            {
                new CartP { CartId = 1, ProductId = 1, Quantity = 2},
                new CartP { CartId = 2, ProductId = 3, Quantity = 1},
                new CartP { CartId = 3, ProductId = 5, Quantity = 4}
            };

            var newCartPs = cartPs.Where(cp => !context.CartPs.Any(dbCartP => dbCartP.CartId == cp.CartId && dbCartP.ProductId == cp.ProductId)).ToList();
            if (newCartPs.Any())
            {
                context.CartPs.AddRange(newCartPs);
                context.SaveChanges();
            }



            // Color
            var colors = new List<Color>
            {
                new Color("Bright Green") { HexCode = "#00C12B" },
                new Color("Bright Red") { HexCode = "#F50606" },
                new Color("Bright Yellow") { HexCode = "#F5DD06" },
                new Color("Orange") { HexCode = "#F57906" },
                new Color("Sky Blue") { HexCode = "#06CAF5" },
                new Color("Deep Blue") { HexCode = "#063AF5" },
                new Color("Violet") { HexCode = "#7D06F5" },
                new Color("Hot Pink") { HexCode = "#F506A4" },
                new Color("White") { HexCode = "#FFFFFF" },
                new Color("Black") { HexCode = "#000000" },
                new Color("Dark Brown") { HexCode = "#4F4631" },
                new Color("Dark Green") { HexCode = "#314F4A" },
                new Color("Dark Blue") { HexCode = "#31344F" }
            };

            var newColors = colors.Where(c => !context.Colors.Any(dbColor => dbColor.Name == c.Name)).ToList();
            if (newColors.Any())
            {
                context.Colors.AddRange(newColors);
                context.SaveChanges();
            }



            // ColorP
            var colorPs = new List<ColorP>
            {
                new ColorP { ColorId = 1, ProductId = 1 },
                new ColorP { ColorId = 8, ProductId = 1 },
                new ColorP { ColorId = 4, ProductId = 1 },
                new ColorP { ColorId = 10, ProductId = 1 },
                new ColorP { ColorId = 7, ProductId = 1 },
                new ColorP { ColorId = 3, ProductId = 2 },
                new ColorP { ColorId = 5, ProductId = 2 },
                new ColorP { ColorId = 4, ProductId = 2 },
                new ColorP { ColorId = 8, ProductId = 3 },
                new ColorP { ColorId = 10, ProductId = 3 },
                new ColorP { ColorId = 6, ProductId = 3 },
                new ColorP { ColorId = 5, ProductId = 3 },
                new ColorP { ColorId = 9, ProductId = 3 },
                new ColorP { ColorId = 1, ProductId = 4 },
                new ColorP { ColorId = 5, ProductId = 4 },
                new ColorP { ColorId = 10, ProductId = 4 },
                new ColorP { ColorId = 7, ProductId = 4 },
                new ColorP { ColorId = 8, ProductId = 5 },
                new ColorP { ColorId = 1, ProductId = 5 },
                new ColorP { ColorId = 5, ProductId = 5 },
                new ColorP { ColorId = 4, ProductId = 6 },
                new ColorP { ColorId = 7, ProductId = 6 },
                new ColorP { ColorId = 10, ProductId = 6 },
                new ColorP { ColorId = 8, ProductId = 7 },
                new ColorP { ColorId = 6, ProductId = 7 },
                new ColorP { ColorId = 3, ProductId = 7 },
                new ColorP { ColorId = 9, ProductId = 8 },
                new ColorP { ColorId = 8, ProductId = 8 },
                new ColorP { ColorId = 4, ProductId = 8 },
                new ColorP { ColorId = 7, ProductId = 8 },
                new ColorP { ColorId = 2, ProductId = 9 },
                new ColorP { ColorId = 7, ProductId = 9 },
                new ColorP { ColorId = 6, ProductId = 9 },
                new ColorP { ColorId = 4, ProductId = 9 },
                new ColorP { ColorId = 1, ProductId = 10 },
                new ColorP { ColorId = 5, ProductId = 10 },
                new ColorP { ColorId = 6, ProductId = 10 },
                new ColorP { ColorId = 9, ProductId = 10 },
                new ColorP { ColorId = 4, ProductId = 11 },
                new ColorP { ColorId = 5, ProductId = 11 },
                new ColorP { ColorId = 8, ProductId = 11 },
                new ColorP { ColorId = 1, ProductId = 11 },
                new ColorP { ColorId = 9, ProductId = 11 },
                new ColorP { ColorId = 9, ProductId = 12 },
                new ColorP { ColorId = 1, ProductId = 12 },
                new ColorP { ColorId = 10, ProductId = 12 }
            };

            var newColorPs = colorPs.Where(cp => !context.ColorPs.Any(dbColorP => dbColorP.ColorId == cp.ColorId && dbColorP.ProductId == cp.ProductId)).ToList();
            if (newColorPs.Any())
            {
                context.ColorPs.AddRange(newColorPs);
                context.SaveChanges();
            }



            // DiscountBrand
            var discountBrands = new List<DiscountBrand>
            {
                new DiscountBrand { DiscountId = 1, BrandId = 1 }
            };

            var newDiscountBrands = discountBrands.Where(db => !context.DiscountBrands.Any(dbBrand => dbBrand.DiscountId == db.DiscountId && dbBrand.BrandId == db.BrandId)).ToList();
            if (newDiscountBrands.Any())
            {
                context.DiscountBrands.AddRange(newDiscountBrands);
                context.SaveChanges();
            }



            //DressStyle
            var dressStyles = new List<DressStyle>
            {
                new DressStyle("Casual"),
                new DressStyle("Formal"),
                new DressStyle("Party"),
                new DressStyle("Gym")
            };

            var newDressStyles = dressStyles.Where(ds => !context.DressStyles.Any(dbDressStyle => dbDressStyle.Name == ds.Name)).ToList();
            if (newDressStyles.Any())
            {
                context.DressStyles.AddRange(newDressStyles);
                context.SaveChanges();
            }



            // DressStyleP
            var dressStylePs = new List<DressStyleP>
            {
                new DressStyleP { DressStyleId = 1, ProductId = 10 },
                new DressStyleP { DressStyleId = 1, ProductId = 11 },
                new DressStyleP { DressStyleId = 1, ProductId = 12 },
                new DressStyleP { DressStyleId = 1, ProductId = 2 },
                new DressStyleP { DressStyleId = 1, ProductId = 3 },
                new DressStyleP { DressStyleId = 1, ProductId = 4 },
                new DressStyleP { DressStyleId = 1, ProductId = 5 },
                new DressStyleP { DressStyleId = 1, ProductId = 6 },
                new DressStyleP { DressStyleId = 1, ProductId = 7 },
                new DressStyleP { DressStyleId = 1, ProductId = 13 },
				new DressStyleP { DressStyleId = 1, ProductId = 14 }
			};

            var newDressStylePs = dressStylePs.Where(dsp => !context.DressStylePs.Any(dbDressStyleP => dbDressStyleP.DressStyleId == dsp.DressStyleId && dbDressStyleP.ProductId == dsp.ProductId)).ToList();

            if (newDressStylePs.Any())
            {
                context.DressStylePs.AddRange(newDressStylePs);
                context.SaveChanges();
            }



            // Outstanding
            var outstandings = new List<Outstanding>
            {
                new Outstanding("On Sale"),
                new Outstanding("New Arrivals"),
                new Outstanding("Top Selling"),
                new Outstanding("You Might Also Like")
            };

            var newOutstandings = outstandings.Where(o => !context.Outstandings.Any(dbOutstanding => dbOutstanding.Name == o.Name)).ToList();

            if (newOutstandings.Any())
            {
                context.Outstandings.AddRange(newOutstandings);
                context.SaveChanges();
            }



            // OutP
            var outPs = new List<OutP>
            {
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
            };

            var newOutPs = outPs.Where(op => !context.OutPs.Any(dbOutP => dbOutP.OutstandingId == op.OutstandingId && dbOutP.ProductId == op.ProductId)).ToList();
            if (newOutPs.Any())
            {
                context.OutPs.AddRange(newOutPs);
                context.SaveChanges();
            }



            // Promotion
            var promotions = new List<Promotion>
            {
                new Promotion("Giảm 20%") { CartId = 1 }
            };

            var newPromotions = promotions.Where(p => !context.Promotions.Any(dbPromotion => dbPromotion.Name == p.Name)).ToList();
            if (newPromotions.Any())
            {
                context.Promotions.AddRange(newPromotions);
                context.SaveChanges();
            }



            //Review
            var reviews = new List<Review>
            {
                new Review { ProductId = 1, UserId = 2, ReviewRating = 5m, Comment = "I'm blown away by the quality and style of the clothes I received from Shop.co. From casual wear to elegant dresses, every piece I've bought has exceeded my expectations.", DatePost = new DateTime(2023, 9, 1) },
                new Review { ProductId = 2, UserId = 3, ReviewRating = 3m, Comment = "The clothes are amazing, comfortable, and stylish. Shop.co really delivers on their promise of high-quality fashion.", DatePost = new DateTime(2023, 9, 2) },
                new Review { ProductId = 3, UserId = 4, ReviewRating = 5m, Comment = "I was hesitant at first, but Shop.co completely changed my shopping experience for the better. The quality is unmatched.", DatePost = new DateTime(2023, 9, 3) },
                new Review { ProductId = 4, UserId = 5, ReviewRating = 4m, Comment = "The variety of styles available is impressive, and everything I’ve bought fits perfectly. Will definitely be buying more.", DatePost = new DateTime(2023, 9, 4) },
                new Review { ProductId = 5, UserId = 6, ReviewRating = 4.5m, Comment = "Shop.co provides excellent customer service and high-quality products. The attention to detail is top-notch.", DatePost = new DateTime(2023, 9, 5) },
                new Review { ProductId = 6, UserId = 7, ReviewRating = 5m, Comment = "I love how versatile the clothing from Shop.co is. It’s perfect for both work and casual wear, making it a great value.", DatePost = new DateTime(2023, 9, 6) },
                new Review { ProductId = 7, UserId = 8, ReviewRating = 4.5m, Comment = "The material is so soft and comfortable, yet durable. These clothes feel like they’ll last me a long time.", DatePost = new DateTime(2023, 9, 7) },
                new Review { ProductId = 8, UserId = 11, ReviewRating = 4m, Comment = "The fashion options from Shop.co are exactly what I’ve been looking for. The designs are trendy and flattering.", DatePost = new DateTime(2023, 9, 8) }, // UserId adjusted
                new Review { ProductId = 9, UserId = 10, ReviewRating = 3m, Comment = "I’ve never had clothes fit so well right out of the box. The sizing is perfect, and the quality is excellent.", DatePost = new DateTime(2023, 9, 9) },
                new Review { ProductId = 10, UserId = 2, ReviewRating = 4.5m, Comment = "Shop.co’s clothes have become my new wardrobe staples. They go with everything, and I get compliments all the time.", DatePost = new DateTime(2023, 9, 10) },
                new Review { ProductId = 11, UserId = 3, ReviewRating = 4m, Comment = "The customer service is great, and the clothes always arrive on time and in perfect condition. I’m a loyal customer now.", DatePost = new DateTime(2023, 9, 11) },
                new Review { ProductId = 12, UserId = 15, ReviewRating = 5m, Comment = "The quality of the fabric is superior to anything I’ve bought before. These clothes hold up really well after washing.", DatePost = new DateTime(2023, 9, 12) }, // UserId adjusted
                new Review { ProductId = 1, UserId = 5, ReviewRating = 4.5m, Comment = "Shop.co’s attention to detail is what sets them apart from other fashion brands. Every item is well-made.", DatePost = new DateTime(2023, 9, 13) },
                new Review { ProductId = 2, UserId = 6, ReviewRating = 4m, Comment = "I appreciate how environmentally friendly the materials are, without compromising on style or quality.", DatePost = new DateTime(2023, 9, 14) },
                new Review { ProductId = 3, UserId = 7, ReviewRating = 5m, Comment = "I always get compliments when I wear something from Shop.co. Their pieces are stylish, modern, and well-crafted.", DatePost = new DateTime(2023, 9, 15) },
                new Review { ProductId = 4, UserId = 9, ReviewRating = 3.5m, Comment = "The clothes are true to size and incredibly comfortable. I’m very happy with everything I’ve purchased so far.", DatePost = new DateTime(2023, 9, 16) }, // UserId adjusted
                new Review { ProductId = 5, UserId = 12, ReviewRating = 4m, Comment = "The delivery was quick, and the packaging was secure. The clothes were even better than I expected.", DatePost = new DateTime(2023, 9, 17) }, // UserId adjusted
                new Review { ProductId = 6, UserId = 10, ReviewRating = 4.5m, Comment = "I love the variety of styles Shop.co offers. There’s something for every occasion, and the quality is top-notch.", DatePost = new DateTime(2023, 9, 18) },
                new Review { ProductId = 7, UserId = 2, ReviewRating = 5m, Comment = "I was skeptical at first, but after my first purchase, I’m completely sold on Shop.co. The clothes are amazing.", DatePost = new DateTime(2023, 9, 19) },
                new Review { ProductId = 8, UserId = 3, ReviewRating = 4.5m, Comment = "The fit and feel of these clothes are perfect. I love how they look, and I feel great wearing them.", DatePost = new DateTime(2023, 9, 20) },
                new Review { ProductId = 2, UserId = 12, ReviewRating = 3m, Comment = "The fabric was nice, but the color wasn't exactly as expected. Still happy with the overall quality.", DatePost = new DateTime(2023, 7, 5) },
                new Review { ProductId = 3, UserId = 18, ReviewRating = 4m, Comment = "Very stylish and comfortable. I received many compliments on the first day I wore it!", DatePost = new DateTime(2023, 6, 22) },
                new Review { ProductId = 4, UserId = 10, ReviewRating = 5m, Comment = "This is one of the best purchases I've made this year! Highly recommend to anyone looking for quality clothes.", DatePost = new DateTime(2023, 9, 11) }, // UserId adjusted
                new Review { ProductId = 5, UserId = 13, ReviewRating = 3m, Comment = "The quality is okay, but it didn’t quite meet my expectations. The design was good though.", DatePost = new DateTime(2023, 7, 9) },
                new Review { ProductId = 6, UserId = 18, ReviewRating = 4m, Comment = "The clothes fit really well and are comfortable to wear. I’m very happy with this purchase.", DatePost = new DateTime(2023, 6, 2) },
                new Review { ProductId = 7, UserId = 19, ReviewRating = 5m, Comment = "Amazing quality for the price! The fabric feels soft and durable. Highly recommend this shop.", DatePost = new DateTime(2023, 4, 25) },
                new Review { ProductId = 8, UserId = 20, ReviewRating = 5m, Comment = "The quality of the fabric and stitching is top-notch. I'm extremely satisfied with this purchase.", DatePost = new DateTime(2023, 3, 10) },
                new Review { ProductId = 9, UserId = 7, ReviewRating = 4m, Comment = "Good quality overall, but the color faded a little after the first wash. Still, it’s a great buy.", DatePost = new DateTime(2023, 2, 22) },
                new Review { ProductId = 10, UserId = 6, ReviewRating = 5m, Comment = "I’m blown away by the quality and style of the clothes I received. Every piece exceeded my expectations!", DatePost = new DateTime(2023, 9, 4) },
                new Review { ProductId = 11, UserId = 11, ReviewRating = 4m, Comment = "The designs are unique and the fabric feels great. My only complaint is the slightly tight fit.", DatePost = new DateTime(2023, 5, 15) },
                new Review { ProductId = 12, UserId = 8, ReviewRating = 5m, Comment = "This is one of my favorite purchases so far! The clothes fit perfectly and look great.", DatePost = new DateTime(2023, 7, 28) },
                new Review { ProductId = 1, UserId = 16, ReviewRating = 3m, Comment = "The material was decent, but the shipping took a bit longer than expected. Overall, it’s a good buy.", DatePost = new DateTime(2023, 7, 23) },
                new Review { ProductId = 2, UserId = 2, ReviewRating = 4m, Comment = "The packaging was professional, and the clothes were of good quality. Very satisfied with this purchase.", DatePost = new DateTime(2023, 8, 1) },
                new Review { ProductId = 3, UserId = 17, ReviewRating = 2m, Comment = "Not very happy with the fit. The material was okay, but the sizing was too tight.", DatePost = new DateTime(2023, 9, 21) },
                new Review { ProductId = 4, UserId = 11, ReviewRating = 5m, Comment = "Superb quality! The clothes look and feel fantastic. I’m really happy with my order.", DatePost = new DateTime(2023, 8, 19) },
                new Review { ProductId = 5, UserId = 16, ReviewRating = 3m, Comment = "The quality is okay, but it didn’t quite meet my expectations. The design was good though.", DatePost = new DateTime(2023, 7, 9) },
                new Review { ProductId = 6, UserId = 15, ReviewRating = 4m, Comment = "The clothes fit really well and are comfortable to wear. I’m very happy with this purchase.", DatePost = new DateTime(2023, 6, 2) },
                new Review { ProductId = 7, UserId = 20, ReviewRating = 5m, Comment = "Amazing quality for the price! The fabric feels soft and durable. Highly recommend this shop.", DatePost = new DateTime(2023, 4, 25) },
                new Review { ProductId = 8, UserId = 9, ReviewRating = 2m, Comment = "The clothes were fine, but the size wasn’t right for me. I may have to return this item.", DatePost = new DateTime(2023, 3, 15) },
                new Review { ProductId = 9, UserId = 5, ReviewRating = 4m, Comment = "Nice clothes, but the stitching could be improved. Still, I’m happy with my purchase.", DatePost = new DateTime(2023, 8, 8) },
                new Review { ProductId = 10, UserId = 12, ReviewRating = 5m, Comment = "These clothes are exactly what I was looking for. The design and quality are excellent!", DatePost = new DateTime(2023, 2, 11) },
                new Review { ProductId = 11, UserId = 18, ReviewRating = 3m, Comment = "Good quality overall, but the delivery took longer than expected. Still satisfied with the purchase.", DatePost = new DateTime(2023, 9, 6) },
                new Review { ProductId = 12, UserId = 20, ReviewRating = 5m, Comment = "This is one of my favorite purchases so far! The clothes fit perfectly and look great.", DatePost = new DateTime(2023, 7, 28) }
            };



            var newReviews = reviews.Where(r => !context.Reviews.Any(dbReview => dbReview.ProductId == r.ProductId && dbReview.UserId == r.UserId)).ToList();
            if (newReviews.Any())
            {
                context.Reviews.AddRange(newReviews);
                context.SaveChanges();
            }



            // Size
            var sizes = new List<Size>
            {
                new Size("XX-Small"),
                new Size("X-Small"),
                new Size("Small"),
                new Size("Medium"),
                new Size("Large"),
                new Size("X-Large"),
                new Size("XX-Large"),
                new Size("3X-Large"),
                new Size("4X-Large")
            };

            var newSizes = sizes.Where(s => !context.Sizes.Any(dbSize => dbSize.Name == s.Name)).ToList();
            if (newSizes.Any())
            {
                context.Sizes.AddRange(newSizes);
                context.SaveChanges();
            }



            // SizeP
            var sizePs = new List<SizeP>
            {
                new SizeP { SizeId = 1, ProductId = 1 },
                new SizeP { SizeId = 2, ProductId = 1 },
                new SizeP { SizeId = 5, ProductId = 1 },
                new SizeP { SizeId = 7, ProductId = 1 },
                new SizeP { SizeId = 6, ProductId = 1 },
                new SizeP { SizeId = 9, ProductId = 2 },
                new SizeP { SizeId = 2, ProductId = 2 },
                new SizeP { SizeId = 7, ProductId = 2 },
                new SizeP { SizeId = 6, ProductId = 2 },
                new SizeP { SizeId = 3, ProductId = 2 },
                new SizeP { SizeId = 3, ProductId = 3 },
                new SizeP { SizeId = 2, ProductId = 3 },
                new SizeP { SizeId = 8, ProductId = 3 },
                new SizeP { SizeId = 4, ProductId = 3 },
                new SizeP { SizeId = 7, ProductId = 3 },
                new SizeP { SizeId = 5, ProductId = 3 },
                new SizeP { SizeId = 9, ProductId = 4 },
                new SizeP { SizeId = 2, ProductId = 4 },
                new SizeP { SizeId = 5, ProductId = 4 },
                new SizeP { SizeId = 6, ProductId = 4 },
                new SizeP { SizeId = 1, ProductId = 4 },
                new SizeP { SizeId = 1, ProductId = 5 },
                new SizeP { SizeId = 2, ProductId = 5 },
                new SizeP { SizeId = 5, ProductId = 5 },
                new SizeP { SizeId = 8, ProductId = 5 },
                new SizeP { SizeId = 3, ProductId = 5 },
                new SizeP { SizeId = 7, ProductId = 5 },
                new SizeP { SizeId = 9, ProductId = 5 },
                new SizeP { SizeId = 4, ProductId = 5 },
                new SizeP { SizeId = 2, ProductId = 6 },
                new SizeP { SizeId = 1, ProductId = 6 },
                new SizeP { SizeId = 7, ProductId = 6 },
                new SizeP { SizeId = 9, ProductId = 6 },
                new SizeP { SizeId = 3, ProductId = 6 },
                new SizeP { SizeId = 5, ProductId = 6 },
                new SizeP { SizeId = 3, ProductId = 7 },
                new SizeP { SizeId = 8, ProductId = 7 },
                new SizeP { SizeId = 2, ProductId = 7 },
                new SizeP { SizeId = 6, ProductId = 7 },
                new SizeP { SizeId = 4, ProductId = 7 },
                new SizeP { SizeId = 5, ProductId = 7 },
                new SizeP { SizeId = 2, ProductId = 8 },
                new SizeP { SizeId = 7, ProductId = 8 },
                new SizeP { SizeId = 8, ProductId = 8 },
                new SizeP { SizeId = 5, ProductId = 8 },
                new SizeP { SizeId = 1, ProductId = 8 },
                new SizeP { SizeId = 5, ProductId = 9 },
                new SizeP { SizeId = 9, ProductId = 9 },
                new SizeP { SizeId = 6, ProductId = 9 },
                new SizeP { SizeId = 8, ProductId = 9 },
                new SizeP { SizeId = 4, ProductId = 10 },
                new SizeP { SizeId = 5, ProductId = 10 },
                new SizeP { SizeId = 9, ProductId = 10 },
                new SizeP { SizeId = 3, ProductId = 10 },
                new SizeP { SizeId = 8, ProductId = 10 },
                new SizeP { SizeId = 6, ProductId = 10 },
                new SizeP { SizeId = 9, ProductId = 11 },
                new SizeP { SizeId = 3, ProductId = 11 },
                new SizeP { SizeId = 2, ProductId = 11 },
                new SizeP { SizeId = 6, ProductId = 11 },
                new SizeP { SizeId = 5, ProductId = 12 },
                new SizeP { SizeId = 8, ProductId = 12 },
                new SizeP { SizeId = 3, ProductId = 12 },
                new SizeP { SizeId = 9, ProductId = 12 },
                new SizeP { SizeId = 4, ProductId = 12 },
                new SizeP { SizeId = 2, ProductId = 12 },
                new SizeP { SizeId = 7, ProductId = 12 }
            };

            var newSizePs = sizePs.Where(sp => !context.SizePs.Any(dbSizeP => dbSizeP.SizeId == sp.SizeId && dbSizeP.ProductId == sp.ProductId)).ToList();
            if (newSizePs.Any())
            {
                context.SizePs.AddRange(newSizePs);
                context.SaveChanges();
            }



            // UserPromotion
            var userPromotions = new List<UserPromotion>
            {
                new UserPromotion { UserId = 1, PromotionId = 1 }
            };

            var newUserPromotions = userPromotions.Where(up => !context.UserPromotions.Any(dbUserPromotion => dbUserPromotion.UserId == up.UserId && dbUserPromotion.PromotionId == up.PromotionId)).ToList();
            if (newUserPromotions.Any())
            {
                context.UserPromotions.AddRange(newUserPromotions);
                context.SaveChanges();
            }
        }
    }
}
