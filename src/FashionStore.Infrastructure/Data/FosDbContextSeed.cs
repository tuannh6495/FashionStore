﻿using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FashionStore.Infrastructure.Data
{
    public static class FosDbContextSeed
    {
        public static void Seed(FosDbContext context)
        {
            context.Database.Migrate();

            //AppUser
            //var users = new List<AppUser>
            //{
            //    new AppUser("Admin", "Password1", "admin@example.com", "John", "Doe"),
            //    new AppUser("User1", "Password2", "user1@example.com", "Jane", "Smith"),
            //    new AppUser("User2", "Password3", "user2@example.com", "Michael", "Johnson"),
            //    new AppUser("User3", "Password4", "user3@example.com", "Emily", "Davis"),
            //    new AppUser("User4", "Password5", "user4@example.com", "Chris", "Wilson"),
            //    new AppUser("User5", "Password6", "user5@example.com", "Anna", "Taylor"),
            //    new AppUser("User6", "Password7", "user6@example.com", "David", "Anderson"),
            //    new AppUser("User7", "Password8", "user7@example.com", "Sophia", "Thomas"),
            //    new AppUser("User8", "Password9", "user8@example.com", "Daniel", "Jackson"),
            //    new AppUser("User9", "Password10", "user9@example.com", "Olivia", "White"),
            //    new AppUser("User10", "Password11", "user10@example.com", "Liam", "Walker"),
            //    new AppUser("User11", "Password12", "user11@example.com", "Sophia", "Martinez"),
            //    new AppUser("User12", "Password13", "user12@example.com", "James", "Hernandez"),
            //    new AppUser("User13", "Password14", "user13@example.com", "Isabella", "Robinson"),
            //    new AppUser("User14", "Password15", "user14@example.com", "Benjamin", "Clark"),
            //    new AppUser("User15", "Password16", "user15@example.com", "Mia", "Lewis"),
            //    new AppUser("User16", "Password17", "user16@example.com", "Lucas", "Young"),
            //    new AppUser("User17", "Password18", "user17@example.com", "Charlotte", "King"),
            //    new AppUser("User18", "Password19", "user18@example.com", "Henry", "Scott"),
            //    new AppUser("User19", "Password20", "user19@example.com", "Ava", "Green"),
            //    new AppUser("User20", "Password21", "user20@example.com", "William", "Baker")
            //};

            //var newUsers = users.Where(u => !context.Users.Any(dbUser => dbUser.UserName == u.UserName)).ToList();
            //if (newUsers.Any())
            //{
            //    context.Users.AddRange(newUsers);
            //    context.SaveChanges();
            //}



            // Cart
            var carts = new List<Cart>
            {

            };

            var newCarts = carts.Where(c => !context.Carts.Any(dbCart => dbCart.AppUserId == c.AppUserId)).ToList();
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
                //Hoodie
                new Product(new List<string> { "/Images/Hoodie/Dioramour Hooded Anorak/back.webp", "/Images/Hoodie/Dioramour Hooded Anorak/fore.webp", "/Images/Hoodie/Dioramour Hooded Anorak/model.webp" }, "Dioramour Hooded Anorak")
                {
                    Price = 4050,
                    Description = "Part of the Dioramour capsule, the hooded anorak showcases the black and red Je Vous Adore (I Love You) motif, inspired by the Marc Bohan for Dior archives. Crafted in white technical taffeta jacquard, it features a zip closure and four snap pockets on the front, including two with flaps, while drawstring cords at the bottom offer an optimal fit. The laid-back anorak can be paired with other Dioramour creations to complete the look.",
                    AvgRating = 4.5m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Hoodie/Double-Knit Full-Zip Hoodie/back.avif", "/Images/Hoodie/Double-Knit Full-Zip Hoodie/fore.avif", "/Images/Hoodie/Double-Knit Full-Zip Hoodie/model.avif" }, "Double-Knit Full-Zip Hoodie")
                {
                    Price = 3800,
                    Description = "Made from a smooth cotton-blend fabric, this full-zip hoodie is an easy match for joggers or jeans.",
                    AvgRating = 3.5m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = 54
                },
                new Product(new List<string> { "/Images/Hoodie/Faded Hoodie/back.webp", "/Images/Hoodie/Faded Hoodie/fore.webp", "/Images/Hoodie/Faded Hoodie/model.webp" }, "Faded Hoodie")
                {
                    Price = 5250,
                    Description = "Sweatshirt made of a cotton blend yarn. Adjustable drawstring hood. Long sleeves with ribbed cuffs. Front pouch pocket. Ribbed trims.",
                    AvgRating = 2.5m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = 41
                },
                new Product(new List<string> { "/Images/Hoodie/Faded-Effect Cropped Hoodie/back.jpg", "/Images/Hoodie/Faded-Effect Cropped Hoodie/fore.jpg", "/Images/Hoodie/Faded-Effect Cropped Hoodie/model.jpg" }, "Faded-Effect Cropped Hoodie")
                {
                    Price = 5650,
                    Description = "Cropped hoodie made of 100% faded-effect cotton. Featuring an adjustable drawstring hood, long sleeves, ribbed elastic trims and front zip fastening.\r\n",
                    AvgRating = 4.0m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Hoodie/Hoodie With Pockets/back.webp", "/Images/Hoodie/Hoodie With Pockets/fore.webp", "/Images/Hoodie/Hoodie With Pockets/model.webp" }, "Hoodie With Pockets")
                {
                    Price = 4100,
                    Description = "Cotton-blend jersey hoodie. Long sleeves. Side seam pockets.",
                    AvgRating = 3.0m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = 6
                },
                new Product(new List<string> { "/Images/Hoodie/Illinois Hoodie/back.webp", "/Images/Hoodie/Illinois Hoodie/fore.webp", "/Images/Hoodie/Illinois Hoodie/model.webp" }, "Illinois Hoodie")
                {
                    Price = 5400,
                    Description = "Long sleeve, drop-shoulder sweatshirt with an adjustable drawstring hood. Featuring a front pouch pocket and contrast embroidered text detail on the front.",
                    AvgRating = 1.5m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Hoodie/Jewelled Washed-Effect Sweatshirt/back.webp", "/Images/Hoodie/Jewelled Washed-Effect Sweatshirt/fore.webp", "/Images/Hoodie/Jewelled Washed-Effect Sweatshirt/model.webp" }, "Jewelled Washed-Effect Sweatshirt")
                {
                    Price = 3600,
                    Description = "Washed-effect cotton sweatshirt. V-neckline and hood. Long sleeves finished in ribbed trim. Features a jewel appliqué detail. Front zip fastening.",
                    AvgRating = 5.0m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = 58
                },
                new Product(new List<string> { "/Images/Hoodie/Mercerized Cotton Sleep Hoodie/back.avif", "/Images/Hoodie/Mercerized Cotton Sleep Hoodie/fore.avif", "/Images/Hoodie/Mercerized Cotton Sleep Hoodie/model.avif" }, "Mercerized Cotton Sleep Hoodie")
                {
                    Price = 1750,
                    Description = "Mercerized cotton elevates this sleep hoodie, giving it a smooth, luxurious feel and a fluid drape for ultimate comfort. The Henley neckline is accented with haberdashery-inspired stripes.",
                    AvgRating = 4.5m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = 74
                },
                new Product(new List<string> { "/Images/Hoodie/Nologo Hoodie Medium Fit/back.avif", "/Images/Hoodie/Nologo Hoodie Medium Fit/fore.avif", "/Images/Hoodie/Nologo Hoodie Medium Fit/model.avif" }, "Nologo Hoodie Medium Fit")
                {
                    Price = 1500,
                    Description = "Nologo Hoodie Medium Fit in black and grey archetype fleece, made in Portugal",
                    AvgRating = 3.5m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Hoodie/Paris Liberty Hoodie Oversized In Black/back.avif", "/Images/Hoodie/Paris Liberty Hoodie Oversized In Black/fore.avif", "/Images/Hoodie/Paris Liberty Hoodie Oversized In Black/model.avif" }, "Paris Liberty Hoodie Oversized In Black")
                {
                    Price = 2750,
                    Description = "This item is unisex, hood without drawstring, dropped shoulders, 1 kangaroo pocket on front, gathered at cuffs and waistline, Paris liberty artwork printed at front, faded artwork, destroyed effect, made in Portugal",
                    AvgRating = 4.0m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = 19
                },
                new Product(new List<string> { "/Images/Hoodie/Polo Bear Wool-Cashmere Knit Hoodie/back.avif", "/Images/Hoodie/Polo Bear Wool-Cashmere Knit Hoodie/fore.avif", "/Images/Hoodie/Polo Bear Wool-Cashmere Knit Hoodie/model.avif" }, "Polo Bear Wool-Cashmere Knit Hoodie")
                {
                    Price = 6800,
                    Description = "Knit with a soft blend of wool and cashmere yarns, this hooded sweater is embroidered with Ralph Lauren’s Polo Bear at the front.",
                    AvgRating = 4.0m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Hoodie/Shrunken Fit Fleece Hoodie/back.avif", "/Images/Hoodie/Shrunken Fit Fleece Hoodie/fore.avif", "/Images/Hoodie/Shrunken Fit Fleece Hoodie/model.avif" }, "Shrunken Fit Fleece Hoodie")
                {
                    Price = 2300,
                    Description = "Made with soft fleece for a lived-in feel, this Shrunken Fit hoodie is punctuated with our signature embroidered Pony. Ralph Lauren partners with Better Cotton™ to improve cotton farming globally.",
                    AvgRating = 3.5m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = 72
                },
                new Product(new List<string> { "/Images/Hoodie/Skater Hoodie Oversized In Black Faded/back.avif", "/Images/Hoodie/Skater Hoodie Oversized In Black Faded/fore.avif", "/Images/Hoodie/Skater Hoodie Oversized In Black Faded/model.avif" }, "Skater Hoodie Oversized In Black Faded")
                {
                    Price = 1450,
                    Description = "Your ultimate streetwear staple! Crafted from soft, breathable cotton, this hoodie offers unmatched comfort and durability. Its oversized fit provides a relaxed silhouette, perfect for layering or wearing solo. The unique faded black color adds a trendy touch, making it versatile enough to pair with anything from joggers to jeans. Whether you're hitting the skate park or chilling with friends, this hoodie combines style and functionality for the modern skater. Elevate your wardrobe with this must-have piece!",
                    AvgRating = 2.5m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = 60
                },
                new Product(new List<string> { "/Images/Hoodie/The RL Fleece Logo Hoodie/back.avif", "/Images/Hoodie/The RL Fleece Logo Hoodie/fore.avif", "/Images/Hoodie/The RL Fleece Logo Hoodie/model.avif" }, "The RL Fleece Logo Hoodie")
                {
                    Price = 3150,
                    Description = "Perfect for teaming with sweats, jeans, or shorts, this cotton-blend hoodie is sure to become a well-loved piece. In addition to our signature Pony, it features our logo rendered in felt appliqués and chain-stitched embroidery.",
                    AvgRating = 5.0m,
                    CategoryId = 4,
                    Gender = 0,
                    DiscountId = 50
                },
                new Product(new List<string> { "/Images/Hoodie/Women's Bb Motel Zip-up Hoodie Fitted In Dark Pink/back.avif", "/Images/Hoodie/Women's Bb Motel Zip-up Hoodie Fitted In Dark Pink/fore.avif", "/Images/Hoodie/Women's Bb Motel Zip-up Hoodie Fitted In Dark Pink/model.avif" }, "Women's Bb Motel Zip-up Hoodie Fitted In Dark Pink")
                {
                    Price = 4100,
                    Description = "Elevate your style with the Women's Bb Motel Zip-up Hoodie Fitted In Dark Pink. Designed for a flattering fit, this hoodie combines comfort and chic fashion. The soft fabric ensures all-day wear, while the vibrant dark pink hue adds a pop of color to any outfit. Perfect for layering or wearing on its own, this zip-up hoodie is a versatile addition to your wardrobe, ideal for casual outings or cozy nights in.",
                    AvgRating = 3.0m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = null
                },

                //Jeans
                new Product(new List<string> { "/Images/Jeans/Blue Camo Jacquard Straight Jeans/back.webp", "/Images/Jeans/Blue Camo Jacquard Straight Jeans/fore.webp", "/Images/Jeans/Blue Camo Jacquard Straight Jeans/model.webp" }, "Blue Camo Jacquard Straight Jeans")
                {
                    Price = 4500,
                    Description = "These 100% cotton jeans have a straight leg and feature an all-over jacquard camo print with small arrow logo at the hip. Made in Italy.",
                    AvgRating = 4.0m,
                    CategoryId = 5,
                    Gender = 0,
                    DiscountId = 15
                },
                new Product(new List<string> { "/Images/Jeans/Hampton Relaxed Straight Jean/back.avif", "/Images/Jeans/Hampton Relaxed Straight Jean/fore.avif", "/Images/Jeans/Hampton Relaxed Straight Jean/model.avif" }, "Hampton Relaxed Straight Jean")
                {
                    Price = 5200,
                    Description = "Polo’s straight-leg jean features a mid-rise with an easy, relaxed fit through the seat and the thigh. This lightweight pair achieves a perfectly broken-in look with hand-sanding.",
                    AvgRating = 3.5m,
                    CategoryId = 5,
                    Gender = 0,
                    DiscountId = 42
                },
                new Product(new List<string> { "/Images/Jeans/High-Rise Boot Jean/back.avif", "/Images/Jeans/High-Rise Boot Jean/fore.avif", "/Images/Jeans/High-Rise Boot Jean/model.avif" }, "High-Rise Boot Jean")
                {
                    Price = 3000,
                    Description = "Made with comfortable right-hand-twill denim, these high-rise boot jeans are dyed for a classic medium wash.",
                    AvgRating = 4.5m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Jeans/High-Waist Trf Stove Pipe Folded Jeans/back.webp", "/Images/Jeans/High-Waist Trf Stove Pipe Folded Jeans/fore.webp", "/Images/Jeans/High-Waist Trf Stove Pipe Folded Jeans/model.webp" }, "High-Waist Trf Stove Pipe Folded Jeans")
                {
                    Price = 7200,
                    Description = "High-waist jeans with belt loops and five pockets. Featuring turn-up hems and zip fly and metal top button fastening.",
                    AvgRating = 2.5m,
                    CategoryId = 5,
                    Gender = 0,
                    DiscountId = 21
                },
                new Product(new List<string> { "/Images/Jeans/Shiny Shredded Wide Jeans/back.webp", "/Images/Jeans/Shiny Shredded Wide Jeans/fore.webp", "/Images/Jeans/Shiny Shredded Wide Jeans/model.webp" }, "Shiny Shredded Wide Jeans")
                {
                    Price = 6700,
                    Description = "These cotton blend jeans feature a wide leg and large shredded areas with contrasting shiny green thread. Made in Italy. As seen in the Fall Winter 2024 Show entitled \"Black by Popular Demand\".",
                    AvgRating = 3.0m,
                    CategoryId = 5,
                    Gender = 0,
                    DiscountId = 33
                },
                new Product(new List<string> { "/Images/Jeans/Trf Cropped Flare High-Waist Jeans/back.webp", "/Images/Jeans/Trf Cropped Flare High-Waist Jeans/fore.webp", "/Images/Jeans/Trf Cropped Flare High-Waist Jeans/model.webp" }, "Trf Cropped Flare High-Waist Jeans")
                {
                    Price = 4200,
                    Description = "High-waist jeans with five pockets. Seamless cropped flared hems. Front zip fly and metal button fastening.",
                    AvgRating = 4.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Jeans/Trf Mid-Rise Baggy Balloon Jeans/back.webp", "/Images/Jeans/Trf Mid-Rise Baggy Balloon Jeans/fore.webp", "/Images/Jeans/Trf Mid-Rise Baggy Balloon Jeans/model.webp" }, "Trf Mid-Rise Baggy Balloon Jeans")
                {
                    Price = 6100,
                    Description = "Mid-rise jeans with a five-pocket design. Twisted seam details. Front zip fly and top metal button fastening.",
                    AvgRating = 2.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = 57
                },
                new Product(new List<string> { "/Images/Jeans/Trf Mom Fit High-Waist Jeans/back.webp", "/Images/Jeans/Trf Mom Fit High-Waist Jeans/fore.webp", "/Images/Jeans/Trf Mom Fit High-Waist Jeans/model.webp" }, "Trf Mom Fit High-Waist Jeans")
                {
                    Price = 5000,
                    Description = "High-waist jeans with belt loops and a five-pocket design. Front zip fly and metal top button fastening.",
                    AvgRating = 3.5m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = 73
                },
                new Product(new List<string> { "/Images/Jeans/Trf Sculpt High-Waist Sculpt Jeans/back.webp", "/Images/Jeans/Trf Sculpt High-Waist Sculpt Jeans/fore.webp", "/Images/Jeans/Trf Sculpt High-Waist Sculpt Jeans/model.webp" }, "Trf Sculpt High-Waist Sculpt Jeans")
                {
                    Price = 4900,
                    Description = "High-waist jeans in super-stretch denim with a five-pocket design. Zip fly and metal top button fastening.",
                    AvgRating = 5.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Jeans/Trf Skinny High-Waist Sculpt Jeans/back.jpg", "/Images/Jeans/Trf Skinny High-Waist Sculpt Jeans/fore.jpg", "/Images/Jeans/Trf Skinny High-Waist Sculpt Jeans/model.webp" }, "Trf Skinny High-Waist Sculpt Jeans")
                {
                    Price = 3500,
                    Description = "High-waist super stretch fabric jeans with five pockets. Front zip and metallic button fastening.",
                    AvgRating = 4.5m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = 66
                },
                new Product(new List<string> { "/Images/Jeans/Trf Wide-Leg High-Waist Full Length Jeans/back.webp", "/Images/Jeans/Trf Wide-Leg High-Waist Full Length Jeans/fore.webp", "/Images/Jeans/Trf Wide-Leg High-Waist Full Length Jeans/model.webp" }, "Trf Wide-Leg High-Waist Full Length Jeans")
                {
                    Price = 5500,
                    Description = "Rigid fabric high-waist jeans with a five-pocket design. Belt loops. Long wide legs. Zip fly and metal top button fastening.",
                    AvgRating = 4.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Jeans/Trf Wide-Leg Mid-Waist Jeans/back.webp", "/Images/Jeans/Trf Wide-Leg Mid-Waist Jeans/fore.webp", "/Images/Jeans/Trf Wide-Leg Mid-Waist Jeans/model.webp" }, "Trf Wide-Leg Mid-Waist Jeans")
                {
                    Price = 6000,
                    Description = "Mid-waist jeans with belt loops and a five-pocket design. Zip fly and metal top button fastening.",
                    AvgRating = 3.5m,
                    CategoryId = 5,
                    Gender = 0,
                    DiscountId = 34
                },
                new Product(new List<string> { "/Images/Jeans/Wide Selvedge Denim Jeans/back.avif", "/Images/Jeans/Wide Selvedge Denim Jeans/fore.avif", "/Images/Jeans/Wide Selvedge Denim Jeans/model.avif" }, "Wide Selvedge Denim Jeans")
                {
                    Price = 7200,
                    Description = "Made from high-quality raw denim, these jeans feature a loose, relaxed fit, providing both comfort and a timeless aesthetic. The selvedge edges ensure the fabric won't unravel, while adding a premium, vintage-inspired detail. Whether dressed up with a crisp shirt or kept casual with a basic tee, these jeans are versatile and built to last, aging beautifully with wear. Ideal for those who appreciate craftsmanship and a classic, laid-back look.",
                    AvgRating = 4.5m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Jeans/Z1975 Straight-Leg High-Waist Denim Jeans/back.jpg", "/Images/Jeans/Z1975 Straight-Leg High-Waist Denim Jeans/fore.jpg", "/Images/Jeans/Z1975 Straight-Leg High-Waist Denim Jeans/model.webp" }, "Z1975 Straight-Leg High-Waist Denim Jeans")
                {
                    Price = 4800,
                    Description = "Combining classic design with a flattering silhouette. Featuring a high-rise waist, these jeans provide a structured, slim fit that elongates the legs, while the straight-leg cut adds a timeless touch. Made from durable denim with a slight stretch, they offer both comfort and style, perfect for day-to-night wear. Whether paired with a tucked-in blouse or a casual t-shirt, these jeans are a versatile staple that easily elevates any outfit.",
                    AvgRating = 2.5m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = 44
                },
                new Product(new List<string> { "/Images/Jeans/Zw Collection Balloon Trousers/back.jpg", "/Images/Jeans/Zw Collection Balloon Trousers/fore.jpg", "/Images/Jeans/Zw Collection Balloon Trousers/model.webp" }, "Zw Collection Balloon Trousers")
                {
                    Price = 5300,
                    Description = "Trousers made of a cotton blend yarn with 29% linen. Featuring front pockets, a washed effect, a zip fly and top button fastening.",
                    AvgRating = 3.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = 61
                },
                new Product(new List<string> { "/Images/Jeans/Zw Collection Loose Fit Mid-Rise Jeans/back.jpg", "/Images/Jeans/Zw Collection Loose Fit Mid-Rise Jeans/fore.jpg", "/Images/Jeans/Zw Collection Loose Fit Mid-Rise Jeans/model.webp" }, "Zw Collection Loose Fit Mid-Rise Jeans")
                {
                    Price = 6100,
                    Description = "With a relaxed, loose fit and a mid-rise waist, these jeans offer a laid-back, casual vibe while maintaining a chic silhouette. The soft, durable denim provides all-day comfort, making them perfect for both casual outings and weekend wear. Pair them with a fitted top for a balanced look, or go oversized for a more relaxed, on-trend outfit. A versatile addition to any denim collection.",
                    AvgRating = 4.0m,
                    CategoryId = 5,
                    Gender = 1,
                    DiscountId = null
                },

                //Shirts
                new Product(new List<string> { "/Images/Shirts/Classic Fit Belting-Print Crepe Shirt/back.avif", "/Images/Shirts/Classic Fit Belting-Print Crepe Shirt/fore.avif", "/Images/Shirts/Classic Fit Belting-Print Crepe Shirt/model.avif" }, "Classic Fit Belting-Print Crepe Shirt")
                {
                    Price = 5400,
                    Description = "Crafted with lightweight crepe de chine for a fluid drape and smooth hand, this collared shirt melds Lauren’s iconic belting print with a travel-inspired motif. “LRL”-engraved metal buttons at the collar and cuffs add a subtle signature finish.",
                    AvgRating = 4.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 22
                },
                new Product(new List<string> { "/Images/Shirts/Classic Fit Satin Charmeuse Shirt/back.avif", "/Images/Shirts/Classic Fit Satin Charmeuse Shirt/fore.avif", "/Images/Shirts/Classic Fit Satin Charmeuse Shirt/model.avif" }, "Classic Fit Satin Charmeuse Shirt")
                {
                    Price = 6800,
                    Description = "Embellished with signature engraved buttons, this timeless shirt is crafted with glossy satin charmeuse for a luxurious Lauren look.",
                    AvgRating = 3.5m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/Contrast Collar Crepe Shirt/back.webp", "/Images/Shirts/Contrast Collar Crepe Shirt/fore.webp", "/Images/Shirts/Contrast Collar Crepe Shirt/model.webp" }, "Contrast Collar Crepe Shirt")
                {
                    Price = 3200,
                    Description = "This versatile piece blends elegance and comfort, featuring a sleek design with a striking contrast collar for a chic touch. Made from lightweight crepe fabric, it drapes beautifully and feels effortless all day long. Perfect for both office wear and casual outings, this shirt adds a refined edge to any outfit.",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 17
                },
                new Product(new List<string> { "/Images/Shirts/Contrast Organza Shirt/back.webp", "/Images/Shirts/Contrast Organza Shirt/fore.webp", "/Images/Shirts/Contrast Organza Shirt/model.webp" }, "Contrast Organza Shirt")
                {
                    Price = 4700,
                    Description = "Turn heads with the Contrast Organza Shirt, a blend of modern sophistication and timeless elegance. Featuring delicate sheer organza with bold contrasting accents, this shirt adds a touch of luxury to your wardrobe. Its airy, lightweight design ensures comfort while exuding high-fashion vibes, perfect for making a statement at both formal events and stylish casual gatherings.",
                    AvgRating = 3.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/Cropped Poplin Shirt/back.jpg", "/Images/Shirts/Cropped Poplin Shirt/fore.jpg", "/Images/Shirts/Cropped Poplin Shirt/model.jpg" }, "Cropped Poplin Shirt")
                {
                    Price = 2500,
                    Description = "Upgrade your wardrobe with the Cropped Poplin Shirt, the perfect mix of classic tailoring and modern flair. Made from crisp, breathable poplin fabric, this cropped silhouette offers a fresh, relaxed fit that's effortlessly stylish. Whether paired with high-waisted pants or a skirt, it's a versatile piece that brings a chic, contemporary edge to your everyday look.",
                    AvgRating = 5.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 31
                },
                new Product(new List<string> { "/Images/Shirts/Garment-Dyed Oxford Shirt/back.avif", "/Images/Shirts/Garment-Dyed Oxford Shirt/fore.avif", "/Images/Shirts/Garment-Dyed Oxford Shirt/model.avif" }, "Garment-Dyed Oxford Shirt")
                {
                    Price = 4600,
                    Description = "The oxford shirt made its debut very early on in Ralph Lauren’s designs, and since then it has solidified its status as a pillar of the Polo look. Our fabric is developed with a secret wash that gives it instant character, ease, and a heathered softness. The formula is so unique, it’s been kept in a safe for more than three decades. In addition to details that evoke its prep-school inspiration, it offers a relaxed feel that produces what we call the perfect “rumple.”",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    Gender = 0,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/GG Supreme Print Silk Shirt/back.avif", "/Images/Shirts/GG Supreme Print Silk Shirt/fore.webp", "/Images/Shirts/GG Supreme Print Silk Shirt/model.avif" }, "GG Supreme Print Silk Shirt")
                {
                    Price = 7300,
                    Description = "Essential pieces in the Cruise 2024 collection are embellished with signature Gucci motifs for the wardrobe. New loungewear blends a relaxed silhouette with rich patterns which speak volume about stylish comfort. This relaxed shirt is presented in beige and ebony silk with a GG Supreme print and is further enriched with a tonal piped trim.",
                    AvgRating = 3.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 44
                },
                new Product(new List<string> { "/Images/Shirts/Gingham Stretch Poplin Shirt/back.avif", "/Images/Shirts/Gingham Stretch Poplin Shirt/fore.avif", "/Images/Shirts/Gingham Stretch Poplin Shirt/model.avif" }, "Gingham Stretch Poplin Shirt")
                {
                    Price = 3800,
                    Description = "This gingham shirt’s poplin combines soft, breathable cotton with extra stretch for added comfort.",
                    AvgRating = 2.5m,
                    CategoryId = 3,
                    Gender = 0,
                    DiscountId = 38
                },
                new Product(new List<string> { "/Images/Shirts/Rhinestone Poplin Shirt/back.jpg", "/Images/Shirts/Rhinestone Poplin Shirt/fore.jpg", "/Images/Shirts/Rhinestone Poplin Shirt/model.jpg" }, "Rhinestone Poplin Shirt")
                {
                    Price = 2900,
                    Description = "Shine in sophistication with the Rhinestone Poplin Shirt. Crafted from crisp poplin fabric, this shirt features dazzling rhinestone embellishments for a touch of glamour. Perfect for adding sparkle to both casual and dressy outfits, it effortlessly combines comfort and elegance. Whether for a night out or a chic daytime look, this shirt elevates your style with subtle yet stunning details.",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/Silk Crêpe De Chine Shirt/back.avif", "/Images/Shirts/Silk Crêpe De Chine Shirt/fore.webp", "/Images/Shirts/Silk Crêpe De Chine Shirt/model.avif" }, "Silk Crêpe De Chine Shirt")
                {
                    Price = 6500,
                    Description = "Earthy tones and muted shades of beige mix with vibrant touches of color to anticipate the arrival of a new season. This sophisticated shirt is made from silk crêpe de chine and defined by a Round Interlocking G embroidery.",
                    AvgRating = 5.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 62
                },
                new Product(new List<string> { "/Images/Shirts/Slim Fit Oxford Shirt/back.avif", "/Images/Shirts/Slim Fit Oxford Shirt/fore.avif", "/Images/Shirts/Slim Fit Oxford Shirt/model.avif" }, "Slim Fit Oxford Shirt")
                {
                    Price = 3100,
                    Description = "Classic in style, this Slim Fit shirt is crafted with Ralph Lauren’s soft cotton oxford and finished with our multicolored signature Pony embroidered at the chest.",
                    AvgRating = 4.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/Stretch Slim Fit Oxford Shirt/back.avif", "/Images/Shirts/Stretch Slim Fit Oxford Shirt/fore.avif", "/Images/Shirts/Stretch Slim Fit Oxford Shirt/model.avif" }, "Stretch Slim Fit Oxford Shirt")
                {
                    Price = 4400,
                    Description = "Cut for our Stretch Slim Fit, this button-down oxford shirt is crafted from a refined stretch cotton fabric and finished with our multicolored signature embroidered Pony at the chest.",
                    AvgRating = 3.5m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 46
                },
                new Product(new List<string> { "/Images/Shirts/Tattersall Stretch Poplin Shirt/back.avif", "/Images/Shirts/Tattersall Stretch Poplin Shirt/fore.avif", "/Images/Shirts/Tattersall Stretch Poplin Shirt/model.avif" }, "Tattersall Stretch Poplin Shirt")
                {
                    Price = 5000,
                    Description = "The Tattersall Stretch Poplin Shirt brings together timeless pattern and modern comfort. Featuring a classic tattersall check, this shirt is crafted from stretch poplin fabric for a perfect blend of structure and flexibility. Its slim fit and breathable material make it ideal for all-day wear, from office meetings to weekend outings. Elevate your style with this versatile piece that offers both sophistication and ease.",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    Gender = 0,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/The Iconic Oxford Shirt/back.avif", "/Images/Shirts/The Iconic Oxford Shirt/fore.avif", "/Images/Shirts/The Iconic Oxford Shirt/model.avif" }, "The Iconic Oxford Shirt")
                {
                    Price = 5800,
                    Description = "The oxford shirt made its debut very early on in Ralph Lauren’s designs, and since then it has solidified its status as a pillar of the Polo look. Our fabric is developed with a secret wash that gives it instant character, ease, and a heathered softness. The formula is so unique, it’s been kept in a safe for more than three decades. In addition to details that evoke its prep-school inspiration, it offers a relaxed feel that produces what we call the perfect “rumple.” Today, Mr. Lauren continues to create countless variations of his iconic shirt, including this relaxed version that is finished with our multicolored signature Pony.",
                    AvgRating = 5.0m,
                    CategoryId = 3,
                    Gender = 0,
                    DiscountId = 3
                },
                new Product(new List<string> { "/Images/Shirts/Washed Organic Denim Shirt/back.avif", "/Images/Shirts/Washed Organic Denim Shirt/fore.avif", "/Images/Shirts/Washed Organic Denim Shirt/model.avif" }, "Washed Organic Denim Shirt")
                {
                    Price = 4200,
                    Description = "Crafted from blue washed organic denim, this shirt is defined by a crystal Interlocking G embroidery on the front. The House explores new takes on the cult fabric, reinterpreting it with different designs and washing techniques that blur the line between vintage and contemporary.",
                    AvgRating = 3.0m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shirts/ZW Collection Shirt With Pocket/back.webp", "/Images/Shirts/ZW Collection Shirt With Pocket/fore.webp", "/Images/Shirts/ZW Collection Shirt With Pocket/model.webp" }, "ZW Collection Shirt With Pocket")
                {
                    Price = 6400,
                    Description = "Discover effortless style with the ZW Collection Shirt With Pocket. This minimalist piece combines sleek design with practical functionality, featuring a roomy front pocket for a modern twist. Made from premium fabric, the shirt offers a relaxed fit that feels as good as it looks. Whether dressed up or down, this versatile shirt is the perfect addition to your wardrobe for a chic, contemporary look.",
                    AvgRating = 4.5m,
                    CategoryId = 3,
                    Gender = 1,
                    DiscountId = 7
                },


                //Shorts
                new Product(new List<string> { "/Images/Shorts/9-Inch Stretch Classic Fit Chino Short/back.avif", "/Images/Shorts/9-Inch Stretch Classic Fit Chino Short/fore.avif", "/Images/Shorts/9-Inch Stretch Classic Fit Chino Short/model.avif" }, "9-Inch Stretch Classic Fit Chino Short")
                {
                    Price = 2500,
                    Description = "With a 9-inch inseam, these shorts hit just above the knee, offering a clean, tailored look suitable for casual or semi-formal settings. Made with a hint of stretch, they provide ease of movement while maintaining their classic fit. Perfect for warm weather, these chino shorts pair effortlessly with polos, tees, or button-downs, making them a must-have for any laid-back yet polished outfit.",
                    AvgRating = 4.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/Denim Shorts/back.avif", "/Images/Shorts/Denim Shorts/fore.avif", "/Images/Shorts/Denim Shorts/model.avif" }, "Denim Shorts")
                {
                    Price = 3000,
                    Description = "Denim shorts are a summer essential, offering a stylish and casual option for warm-weather outfits. Designed for both comfort and versatility, they provide a relaxed, effortless look that pairs well with almost anything, from t-shirts to tank tops. Made from durable denim, these shorts are perfect for daily wear, whether you're out running errands or enjoying a weekend getaway. Their timeless design ensures they never go out of style, making them a staple piece for any casual wardrobe.",
                    AvgRating = 3.5m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 22
                },
                new Product(new List<string> { "/Images/Shorts/Denim Shorts With Horsebit Details/back.avif", "/Images/Shorts/Denim Shorts With Horsebit Details/fore.avif", "/Images/Shorts/Denim Shorts With Horsebit Details/model.avif" }, "Denim Shorts With Horsebit Details")
                {
                    Price = 3400,
                    Description = "A pair of shorts crafted from cotton denim and eriched with Horsebit details at the back pockets. Gucci explores new takes on the cult fabric, reinterpreting it with different designs and washing techniques that blur the line between vintage and contemporary.",
                    AvgRating = 4.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 30
                },
                new Product(new List<string> { "/Images/Shorts/GG Canvas Shorts/back.avif", "/Images/Shorts/GG Canvas Shorts/fore.jpg", "/Images/Shorts/GG Canvas Shorts/model.jpg" }, "GG Canvas Shorts")
                {
                    Price = 4000,
                    Description = "The piece is part of Sabato De Sarno's debut collection, offering a modern take on the House's well-known codes and symbols. Designed with a low waist, this pair of shorts is crafted from Original GG canvas, a signature symbol of the House. Two side and two back pockets with belt loops complete the style for a sartorial touch.",
                    AvgRating = 4.5m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/GG Embossed Leather Short/back.avif", "/Images/Shorts/GG Embossed Leather Short/fore.avif", "/Images/Shorts/GG Embossed Leather Short/model.avif" }, "GG Embossed Leather Short")
                {
                    Price = 5000,
                    Description = "The Fall Winter 2024 collection reinterprets the iconic GG leather with new softness and the House motif embossed in a fresh dimension. These mini shorts are presented in a GG embossed leather and completed with a Hook closure with Gucci engraving.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 100
                },
                new Product(new List<string> { "/Images/Shorts/GG Supreme Silk Shorts/back.avif", "/Images/Shorts/GG Supreme Silk Shorts/fore.avif", "/Images/Shorts/GG Supreme Silk Shorts/model.avif" }, "GG Supreme Silk Shorts")
                {
                    Price = 7216,
                    Description = "Essential pieces in the Cruise 2024 collection are embellished with signature Gucci motifs for the wardrobe. This pair of shorts is presented in GG Supreme printed silk with a tonal piped trim, speaking volumes about stylish comfort.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 22
                },
                new Product(new List<string> { "/Images/Shorts/Lace 20s Denim Short/back.webp", "/Images/Shorts/Lace 20s Denim Short/fore.webp", "/Images/Shorts/Lace 20s Denim Short/model.webp" }, "Lace 20s Denim Short")
                {
                    Price = 3055,
                    Description = "The Lace 20s Denim Short adds a vintage-inspired twist to your casual wardrobe, combining the rugged appeal of denim with delicate lace detailing. These shorts feature a mid-rise fit and are designed to sit comfortably on the hips, while the intricate lace accents give a feminine touch to the classic denim look. Perfect for summer outings or casual weekends, they offer both style and comfort. Pair them with a simple top to let the lace details shine, creating a chic, effortless look with a nostalgic 1920s flair.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/Light Wool Crêpe Shorts/back.avif", "/Images/Shorts/Light Wool Crêpe Shorts/fore.avif", "/Images/Shorts/Light Wool Crêpe Shorts/model.avif" }, "Light Wool Crêpe Shorts")
                {
                    Price = 5546,
                    Description = "The Fall Winter 2024 collection re-envisions traditional ready-to-wear through subtle yet innovative details. These wool crêpe shorts are defined by a Gucci embroidery, Gucci metal detail on the waistband and Gucci zip puller, exploring fresh ways to present the House codes.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/back.avif", "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/fore.avif", "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/model.avif" }, "Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite")
                {
                    Price = 4671,
                    Description = "The Men's Unity Sports Icon Basketball Shorts in Dark Blue/White are designed for peak performance and comfort on and off the court. Featuring a lightweight, breathable fabric, these shorts offer optimal mobility and ventilation, keeping you cool during intense games or workouts. The dark blue color, accented with white details, delivers a sleek, athletic look that matches any gear. With an elastic waistband and a relaxed fit, these basketball shorts ensure a secure yet comfortable fit, making them a versatile choice for both sports and casual wear.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/Minimal Cargo Shorts In Black/back.avif", "/Images/Shorts/Minimal Cargo Shorts In Black/fore.avif", "/Images/Shorts/Minimal Cargo Shorts In Black/model.avif" }, "Minimal Cargo Shorts In Black")
                {
                    Price = 6105,
                    Description = "The Minimal Cargo Shorts in Black are the perfect blend of utility and modern style. Designed with a sleek, streamlined silhouette, these shorts feature multiple spacious pockets for practicality without compromising on a clean, minimalistic look. Made from durable, lightweight fabric, they are ideal for everyday wear, providing comfort and functionality. The versatile black color makes them easy to pair with any outfit, whether you're dressing for a casual day out or an outdoor adventure. These cargo shorts offer the best of both worlds—style and utility in one.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 19
                },
                new Product(new List<string> { "/Images/Shorts/Outline Arrow Linen Short/back.webp", "/Images/Shorts/Outline Arrow Linen Short/fore.jpg", "/Images/Shorts/Outline Arrow Linen Short/model.webp" }, "Outline Arrow Linen Short")
                {
                    Price = 3410,
                    Description = "The Summer Resort capsule takes inspiration from travel and summer light. These 100% linen shorts feature an outlined text logo on the leg and are lined with 100% cotton. Made in Italy.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 38
                },
                new Product(new List<string> { "/Images/Shorts/Poplin Ow Embr Baseball Short/back.jpg", "/Images/Shorts/Poplin Ow Embr Baseball Short/fore.jpg", "/Images/Shorts/Poplin Ow Embr Baseball Short/model.webp" }, "Poplin Ow Embr Baseball Short")
                {
                    Price = 7506,
                    Description = "These 100% cotton poplin baseball shorts feature a large embroidered logo and lace trim. Made in Italy.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/Printed Silk Twill Shorts/back.jpg", "/Images/Shorts/Printed Silk Twill Shorts/fore.avif", "/Images/Shorts/Printed Silk Twill Shorts/model.jpg" }, "Printed Silk Twill Shorts")
                {
                    Price = 6273,
                    Description = "Printed Silk Twill Shorts offer a luxurious and vibrant take on casual summer wear. Made from smooth, lightweight silk twill, these shorts boast an eye-catching print that adds a pop of color and elegance to your wardrobe. The high-quality fabric drapes beautifully, providing a soft, breathable feel for all-day comfort. Perfect for warm days or vacation getaways, these shorts can be dressed up with a blouse and sandals or kept casual with a simple tee. Their bold pattern and refined material make them a standout piece for any fashion-forward look.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/Shorts/Tweed Blend Shorts/back.avif", "/Images/Shorts/Tweed Blend Shorts/fore.avif", "/Images/Shorts/Tweed Blend Shorts/model.webp" }, "Tweed Blend Shorts")
                {
                    Price = 4448,
                    Description = "Introducing new knitwear styles, sophisticated yarn provides volume, and is further elevated through artisanal details which highlight rich textures. With a new focus on yarns, these knits can be worn alone as a standout piece, or layered to complement the Fall Winter 2024 wardrobe. These viscose tweed blend shorts feature an allover sequin embroidery.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Women's Activewear Cycling Shorts In Black/back.avif", "/Images/Shorts/Women's Activewear Cycling Shorts In Black/fore.avif", "/Images/Shorts/Women's Activewear Cycling Shorts In Black/model.avif" }, "Women's Activewear Cycling Shorts In Black")
                {
                    Price = 5114,
                    Description = "The Women's Activewear Cycling Shorts in Black are designed for ultimate performance and comfort during your workouts. Made from moisture-wicking, stretchy fabric, these shorts provide a snug, supportive fit that allows for full mobility while keeping you dry. Their high-waisted design ensures a secure, flattering fit, while the smooth, breathable material minimizes friction, making them ideal for cycling, gym sessions, or outdoor activities. The versatile black color easily pairs with any activewear, making these shorts a staple for any fitness routine, offering both style and functionality.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 6
                },
                new Product(new List<string> { "/Images/Shorts/Wool Mohair Bermuda Shorts/back.avif", "/Images/Shorts/Wool Mohair Bermuda Shorts/fore.avif", "/Images/Shorts/Wool Mohair Bermuda Shorts/model.avif" }, "Wool Mohair Bermuda Shorts")
                {
                    Price = 7761,
                    Description = "The piece is part of Sabato De Sarno's debut collection, offering a modern take on the House's well-known codes and symbols. Presented in light rose, this pair of bermuda is crafted from a blend of wool and mohair. Taking inspiration from traditional sartorial pants, the style is designed with a low waist and a tab with zip closure. The style is completed with two side and two back pockets.",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = null
                },

                //T-Shirt
                new Product(new List<string> { "/Images/T-Shirt/Asymmetric Ribbed T-shirt/back.webp", "/Images/T-Shirt/Asymmetric Ribbed T-shirt/fore.webp", "/Images/T-Shirt/Asymmetric Ribbed T-shirt/model.webp" }, "Asymmetric Ribbed T-shirt")
                {
                    Price = 5950,
                    Description = "Featuring a unique asymmetrical design, this tee stands out with its contemporary cut while maintaining a casual, laid-back vibe. Made from soft, ribbed fabric, it provides a comfortable, stretchy fit that flatters the body. Perfect for elevating your everyday outfits, this T-shirt pairs effortlessly with jeans, skirts, or tailored pants. Its stylish yet minimalist design makes it a versatile piece for both casual and dressy occasions, adding a touch of edge to any look.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Basic Training T-shirt/back.webp", "/Images/T-Shirt/Basic Training T-shirt/fore.webp", "/Images/T-Shirt/Basic Training T-shirt/model.webp" }, "Basic Training T-shirt")
                {
                    Price = 5732,
                    Description = "The Basic Training T-shirt is a must-have for your activewear collection, offering a perfect balance of comfort and functionality. Crafted from lightweight, breathable fabric, this tee is designed to keep you cool and dry during workouts or everyday activities. Its simple, classic design makes it versatile and easy to pair with any gym shorts, leggings, or casual wear. With a comfortable fit and moisture-wicking properties, the Basic Training T-shirt is ideal for everything from intense training sessions to casual errands, making it a reliable go-to for an active lifestyle.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 41
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/back.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/fore.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/model.avif" }, "Cotton Jersey T-shirt With Embroidery")
                {
                    Price = 4967,
                    Description = "A relaxed attitude speaks volume as casual pieces become indispensable. Sweatshirts, hoodies, and t-shirts with drop shoulders, cropped lengths, and generous fits are adorned with signature embellishments. Made from black cotton jersey, this short-sleeved T-shirt is embellished with a sparkling Interlocking G crystal embroidery.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/back.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/fore.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/model.avif" }, "Cotton Jersey T-shirt With Interlocking G")
                {
                    Price = 3961,
                    Description = "A relaxed attitude speaks volume as casual pieces become indispensable. Sweatshirts, hoodies, and t-shirts with drop shoulders, cropped lengths, and generous fits are adorned with signature embellishments. Made from black cotton jersey, this short-sleeved T-shirt is embellished with a sparkling crystal Interlocking G.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton T-shirt With Belt/back.webp", "/Images/T-Shirt/Cotton T-shirt With Belt/fore.webp", "/Images/T-Shirt/Cotton T-shirt With Belt/model.webp" }, "Cotton T-shirt With Belt")
                {
                    Price = 6670,
                    Description = "The Cotton T-shirt with Belt brings a stylish update to a classic silhouette, offering both comfort and shape. Made from soft, breathable cotton, this tee feels light and easy to wear, while the addition of a belt cinches the waist for a flattering, defined look. Perfect for adding a touch of structure to your casual outfits, this T-shirt can be dressed up or down depending on the occasion. Pair it with jeans or skirts for a chic, effortless ensemble that combines relaxed comfort with a polished finish.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Men's T-shirt Oversized In Black/back.avif", "/Images/T-Shirt/Men's T-shirt Oversized In Black/fore.avif", "/Images/T-Shirt/Men's T-shirt Oversized In Black/model.avif" }, "Men's T-shirt Oversized In Black")
                {
                    Price = 6859,
                    Description = "T-Shirt Oversized in black premium jersey Garde-Robe is made up of wardrobe staples in elevated cuts, sharp finishing, and luxe materials without any branding other than bold silhouettes and precise tailoring with minimalist construction techniques.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 65
                },
                new Product(new List<string> { "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/back.webp", "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/fore.webp", "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/model.webp" }, "Monogram Logo Overlay Graphic Classic T-shirt")
                {
                    Price = 6962,
                    Description = "Crafted from 100% cotton, this t-shirt is soft and breathable, perfect for everyday wear. Styled with short sleeves and a crewneck. Cut in a classic fit and features a printed graphic at the front.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = null
                },
                new Product(new List<string> { "/Images/T-Shirt/Polyamide T-shirt/back.jpg", "/Images/T-Shirt/Polyamide T-shirt/fore.webp", "/Images/T-Shirt/Polyamide T-shirt/model.jpg" }, "Polyamide T-shirt")
                {
                    Price = 3746,
                    Description = "The Polyamide T-shirt is designed for those who prioritize both performance and comfort. Made from lightweight, breathable polyamide fabric, this tee offers excellent moisture-wicking properties, ensuring you stay dry and comfortable during workouts or on hot days. Its stretchy material allows for a full range of motion, making it ideal for active pursuits like running, cycling, or gym sessions. The sleek design provides a modern, fitted look, easily pairing with leggings or shorts for a sporty outfit. With its durability and quick-drying capabilities, this Polyamide T-shirt is a versatile addition to any activewear collection.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Regular Fit Interlock T-shirt/back.webp", "/Images/T-Shirt/Regular Fit Interlock T-shirt/fore.webp", "/Images/T-Shirt/Regular Fit Interlock T-shirt/model.webp" }, "Regular Fit Interlock T-shirt")
                {
                    Price = 3475,
                    Description = "Crafted from soft interlock fabric, this tee provides a smooth, luxurious feel against the skin while maintaining a durable construction. Its regular fit offers a relaxed yet flattering silhouette, making it perfect for everyday wear or casual outings. Available in a variety of colors, this T-shirt easily pairs with jeans, shorts, or skirts, allowing for effortless styling. Whether worn alone or layered, the Regular Fit Interlock T-shirt is an essential piece for any casual wardrobe.\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 50
                },
                new Product(new List<string> { "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/back.webp", "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/fore.webp", "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/model.webp" }, "Ribbed Long Sleeve T-shirt")
                {
                    Price = 6250,
                    Description = "The Ribbed Long Sleeve T-shirt is a stylish and cozy essential that blends comfort with a sleek, modern design. Made from soft, ribbed fabric, this tee offers a fitted silhouette that flatters the body while providing warmth with its long sleeves. Its stretchy material ensures ease of movement, making it a great choice for layering or wearing on its own during cooler weather. Whether paired with jeans, skirts, or layered under a jacket, this versatile T-shirt adds a touch of texture and elegance to any casual or semi-formal outfit. Perfect for effortless, everyday style.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 28
                },
                new Product(new List<string> { "/Images/T-Shirt/Striped Heavy Cotton T-shirt/back.webp", "/Images/T-Shirt/Striped Heavy Cotton T-shirt/fore.webp", "/Images/T-Shirt/Striped Heavy Cotton T-shirt/model.jpg" }, "Striped Heavy Cotton T-shirt")
                {
                    Price = 4037,
                    Description = "Made from thick, heavyweight cotton, this tee provides a structured fit that holds its shape over time. The bold stripe pattern adds a timeless, nautical-inspired style, making it a versatile piece for casual or weekend wear. Whether paired with jeans or chinos, this T-shirt adds a touch of effortless cool to your outfit, while the breathable cotton ensures comfort throughout the day. Perfect for those who appreciate both quality and style in their wardrobe essentials.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 11
                },
                new Product(new List<string> { "/Images/T-Shirt/Striped Oversize T-shirt/back.webp", "/Images/T-Shirt/Striped Oversize T-shirt/fore.webp", "/Images/T-Shirt/Striped Oversize T-shirt/model.webp" }, "Striped Oversize T-shirt")
                {
                    Price = 7197,
                    Description = "With its loose, oversized fit and bold stripe pattern, this tee offers a casual, laid-back look while making a stylish statement. Made from soft, breathable fabric, it ensures all-day comfort, perfect for lounging or running errands. The oversized silhouette pairs well with skinny jeans, leggings, or shorts for a balanced outfit, offering both comfort and a trendy edge. Ideal for creating an effortlessly cool and casual style, this T-shirt is a must-have for easy, everyday wear.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 59
                },
                new Product(new List<string> { "/Images/T-Shirt/Textured Jacquard T-shirt/back.jpg", "/Images/T-Shirt/Textured Jacquard T-shirt/fore.webp", "/Images/T-Shirt/Textured Jacquard T-shirt/model.jpg" }, "Textured Jacquard T-shirt")
                {
                    Price = 6926,
                    Description = "Made from soft, high-quality fabric, this tee features a subtle jacquard texture that adds depth and sophistication to your outfit. Its breathable, lightweight material ensures comfort while the textured design elevates it beyond a basic T-shirt, making it perfect for both casual and semi-formal occasions. Pair it with tailored trousers or jeans for a polished yet effortless look. This T-shirt combines comfort with a touch of luxury, ideal for those who appreciate subtle, stylish details.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 100
                },
                new Product(new List<string> { "/Images/T-Shirt/Viscose Long Sleeve T-shirt/back.webp", "/Images/T-Shirt/Viscose Long Sleeve T-shirt/fore.webp", "/Images/T-Shirt/Viscose Long Sleeve T-shirt/model.webp" }, "Viscose Long Sleeve T-shirt")
                {
                    Price = 4757,
                    Description = "The Viscose Long Sleeve T-shirt is the perfect combination of comfort and elegance. Made from soft, breathable viscose fabric, this tee offers a lightweight, silky feel that drapes beautifully on the body. Its long sleeves provide warmth and coverage, making it a versatile piece for layering or wearing on its own during cooler months. With a sleek, fitted silhouette, this T-shirt easily pairs with jeans, skirts, or trousers for both casual and more polished looks. Ideal for those who appreciate style and comfort in their everyday wardrobe.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 17
                },
                new Product(new List<string> { "/Images/T-Shirt/V-neck Ribbed T-shirt/back.webp", "/Images/T-Shirt/V-neck Ribbed T-shirt/fore.webp", "/Images/T-Shirt/V-neck Ribbed T-shirt/model.webp" }, "V-neck Ribbed T-shirt")
                {
                    Price = 4195,
                    Description = "The V-neck Ribbed T-shirt offers a flattering and versatile style that suits any occasion. Made from soft, stretchy ribbed fabric, this tee provides a close, comfortable fit that accentuates your silhouette. The V-neckline adds a feminine touch, making it perfect for layering under jackets or wearing on its own. Whether paired with jeans, skirts, or tailored pants, this T-shirt is a timeless staple that easily transitions from casual to more dressed-up looks. Its combination of ribbed texture and classic V-neck design makes it an essential piece for any wardrobe.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 78
                },
                new Product(new List<string> { "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/back.avif", "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/fore.avif", "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/model.avif" }, "Women's Activewear T-shirt Fitted In Black")
                {
                    Price = 5102,
                    Description = "Crafted from moisture-wicking, stretch fabric, this tee hugs the body for a flattering, streamlined fit while allowing full freedom of movement. Its breathable material keeps you cool and comfortable during intense workouts, from the gym to outdoor runs. The fitted design ensures a modern, athletic look that pairs perfectly with leggings, shorts, or joggers. Whether you're training or lounging, this black activewear T-shirt combines function with a versatile, stylish edge for any fitness routine.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 74
                },
                new Product(new List<string> { "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/back.jpg", "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/fore.avif", "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/model.avif" }, "Women's Ciao Bello Shrunk T-shirt In Black")
                {
                    Price = 4667,
                    Description = "The Women's Ciao Bello Shrunk T-shirt in Black offers a fun, trendy take on a wardrobe essential. With its slightly shrunken fit, this tee hugs the body in all the right places, giving a flattering, form-fitting look. The playful \"Ciao Bello\" graphic adds a bold, stylish touch, perfect for making a statement with your casual outfits. Made from soft, comfortable fabric, it’s easy to pair with anything from jeans to skirts, making it a versatile go-to for everyday wear. Ideal for those who love a little flair in their basics.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 86
                },
                new Product(new List<string> { "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/back.jpg", "/Images/T-Shirt/test/fore", "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/model.avif" }, "test")
                {
                    Price = 4667,
                    Description = "The Women's Ciao Bello Shrunk T-shirt in Black offers a fun, trendy take on a wardrobe essential. With its slightly shrunken fit, this tee hugs the body in all the right places, giving a flattering, form-fitting look. The playful \"Ciao Bello\" graphic adds a bold, stylish touch, perfect for making a statement with your casual outfits. Made from soft, comfortable fabric, it’s easy to pair with anything from jeans to skirts, making it a versatile go-to for everyday wear. Ideal for those who love a little flair in their basics.",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 86
                },
            };

            var validDiscountIds = context.Discounts.Select(d => d.Id).ToHashSet();

            var newProducts = products
                .Where(p =>
                    !context.Products.Any(dbProduct => dbProduct.Name == p.Name)
                    && (p.DiscountId == null || validDiscountIds.Contains((int)p.DiscountId)))
                .ToList();
            if (newProducts.Any())
            {
                context.Products.AddRange(newProducts);
                context.SaveChanges();
            }



            // CartP
            var cartPs = new List<CartP>
            {

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

            };

            var newColorPs = colorPs.Where(cp => !context.ColorPs.Any(dbColorP => dbColorP.ColorId == cp.ColorId && dbColorP.ProductId == cp.ProductId)).ToList();
            if (newColorPs.Any())
            {
                context.ColorPs.AddRange(newColorPs);
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
                new DressStyleP {DressStyleId = 1, ProductId = 81}
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
                new Outstanding("New Arrivals"),
                new Outstanding("Top Selling"),
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
                new Review { ProductId = 1, ReviewRating = 5m, Comment = "I'm blown away by the quality and style of the clothes I received from Shop.co. From casual wear to elegant dresses, every piece I've bought has exceeded my expectations.", DatePost = new DateTime(2023, 9, 1) },
                new Review { ProductId = 2, ReviewRating = 3m, Comment = "The clothes are amazing, comfortable, and stylish. Shop.co really delivers on their promise of high-quality fashion.", DatePost = new DateTime(2023, 9, 2) },
                new Review { ProductId = 3, ReviewRating = 5m, Comment = "I was hesitant at first, but Shop.co completely changed my shopping experience for the better. The quality is unmatched.", DatePost = new DateTime(2023, 9, 3) },
                new Review { ProductId = 4, ReviewRating = 4m, Comment = "The variety of styles available is impressive, and everything I’ve bought fits perfectly. Will definitely be buying more.", DatePost = new DateTime(2023, 9, 4) },
                new Review { ProductId = 5, ReviewRating = 4.5m, Comment = "Shop.co provides excellent customer service and high-quality products. The attention to detail is top-notch.", DatePost = new DateTime(2023, 9, 5) },
                new Review { ProductId = 6, ReviewRating = 5m, Comment = "I love how versatile the clothing from Shop.co is. It’s perfect for both work and casual wear, making it a great value.", DatePost = new DateTime(2023, 9, 6) },
                new Review { ProductId = 7, ReviewRating = 4.5m, Comment = "The material is so soft and comfortable, yet durable. These clothes feel like they’ll last me a long time.", DatePost = new DateTime(2023, 9, 7) },
                new Review { ProductId = 8, ReviewRating = 4m, Comment = "The fashion options from Shop.co are exactly what I’ve been looking for. The designs are trendy and flattering.", DatePost = new DateTime(2023, 9, 8) }, // UserId adjusted
                new Review { ProductId = 9, ReviewRating = 3m, Comment = "I’ve never had clothes fit so well right out of the box. The sizing is perfect, and the quality is excellent.", DatePost = new DateTime(2023, 9, 9) },
                new Review { ProductId = 10, ReviewRating = 4.5m, Comment = "Shop.co’s clothes have become my new wardrobe staples. They go with everything, and I get compliments all the time.", DatePost = new DateTime(2023, 9, 10) },
                new Review { ProductId = 11, ReviewRating = 4m, Comment = "The customer service is great, and the clothes always arrive on time and in perfect condition. I’m a loyal customer now.", DatePost = new DateTime(2023, 9, 11) },
                new Review { ProductId = 12, ReviewRating = 5m, Comment = "The quality of the fabric is superior to anything I’ve bought before. These clothes hold up really well after washing.", DatePost = new DateTime(2023, 9, 12) }, // UserId adjusted
                new Review { ProductId = 1, ReviewRating = 4.5m, Comment = "Shop.co’s attention to detail is what sets them apart from other fashion brands. Every item is well-made.", DatePost = new DateTime(2023, 9, 13) },
                new Review { ProductId = 2, ReviewRating = 4m, Comment = "I appreciate how environmentally friendly the materials are, without compromising on style or quality.", DatePost = new DateTime(2023, 9, 14) },
                new Review { ProductId = 3, ReviewRating = 5m, Comment = "I always get compliments when I wear something from Shop.co. Their pieces are stylish, modern, and well-crafted.", DatePost = new DateTime(2023, 9, 15) },
                new Review { ProductId = 4, ReviewRating = 3.5m, Comment = "The clothes are true to size and incredibly comfortable. I’m very happy with everything I’ve purchased so far.", DatePost = new DateTime(2023, 9, 16) }, // UserId adjusted
                new Review { ProductId = 5, ReviewRating = 4m, Comment = "The delivery was quick, and the packaging was secure. The clothes were even better than I expected.", DatePost = new DateTime(2023, 9, 17) }, // UserId adjusted
                new Review { ProductId = 6, ReviewRating = 4.5m, Comment = "I love the variety of styles Shop.co offers. There’s something for every occasion, and the quality is top-notch.", DatePost = new DateTime(2023, 9, 18) },
                new Review { ProductId = 7, ReviewRating = 5m, Comment = "I was skeptical at first, but after my first purchase, I’m completely sold on Shop.co. The clothes are amazing.", DatePost = new DateTime(2023, 9, 19) },
                new Review { ProductId = 8, ReviewRating = 4.5m, Comment = "The fit and feel of these clothes are perfect. I love how they look, and I feel great wearing them.", DatePost = new DateTime(2023, 9, 20) },
                new Review { ProductId = 2, ReviewRating = 3m, Comment = "The fabric was nice, but the color wasn't exactly as expected. Still happy with the overall quality.", DatePost = new DateTime(2023, 7, 5) },
                new Review { ProductId = 3, ReviewRating = 4m, Comment = "Very stylish and comfortable. I received many compliments on the first day I wore it!", DatePost = new DateTime(2023, 6, 22) },
                new Review { ProductId = 4, ReviewRating = 5m, Comment = "This is one of the best purchases I've made this year! Highly recommend to anyone looking for quality clothes.", DatePost = new DateTime(2023, 9, 11) }, // UserId adjusted
                new Review { ProductId = 5, ReviewRating = 3m, Comment = "The quality is okay, but it didn’t quite meet my expectations. The design was good though.", DatePost = new DateTime(2023, 7, 9) },
                new Review { ProductId = 6, ReviewRating = 4m, Comment = "The clothes fit really well and are comfortable to wear. I’m very happy with this purchase.", DatePost = new DateTime(2023, 6, 2) },
                new Review { ProductId = 7, ReviewRating = 5m, Comment = "Amazing quality for the price! The fabric feels soft and durable. Highly recommend this shop.", DatePost = new DateTime(2023, 4, 25) },
                new Review { ProductId = 8, ReviewRating = 5m, Comment = "The quality of the fabric and stitching is top-notch. I'm extremely satisfied with this purchase.", DatePost = new DateTime(2023, 3, 10) },
                new Review { ProductId = 9, ReviewRating = 4m, Comment = "Good quality overall, but the color faded a little after the first wash. Still, it’s a great buy.", DatePost = new DateTime(2023, 2, 22) },
                new Review { ProductId = 10, ReviewRating = 5m, Comment = "I’m blown away by the quality and style of the clothes I received. Every piece exceeded my expectations!", DatePost = new DateTime(2023, 9, 4) },
                new Review { ProductId = 11, ReviewRating = 4m, Comment = "The designs are unique and the fabric feels great. My only complaint is the slightly tight fit.", DatePost = new DateTime(2023, 5, 15) },
                new Review { ProductId = 12, ReviewRating = 5m, Comment = "This is one of my favorite purchases so far! The clothes fit perfectly and look great.", DatePost = new DateTime(2023, 7, 28) },
                new Review { ProductId = 1, ReviewRating = 3m, Comment = "The material was decent, but the shipping took a bit longer than expected. Overall, it’s a good buy.", DatePost = new DateTime(2023, 7, 23) },
                new Review { ProductId = 2, ReviewRating = 4m, Comment = "The packaging was professional, and the clothes were of good quality. Very satisfied with this purchase.", DatePost = new DateTime(2023, 8, 1) },
                new Review { ProductId = 3, ReviewRating = 2m, Comment = "Not very happy with the fit. The material was okay, but the sizing was too tight.", DatePost = new DateTime(2023, 9, 21) },
                new Review { ProductId = 4, ReviewRating = 5m, Comment = "Superb quality! The clothes look and feel fantastic. I’m really happy with my order.", DatePost = new DateTime(2023, 8, 19) },
                new Review { ProductId = 5, ReviewRating = 3m, Comment = "The quality is okay, but it didn’t quite meet my expectations. The design was good though.", DatePost = new DateTime(2023, 7, 9) },
                new Review { ProductId = 6, ReviewRating = 4m, Comment = "The clothes fit really well and are comfortable to wear. I’m very happy with this purchase.", DatePost = new DateTime(2023, 6, 2) },
                new Review { ProductId = 7, ReviewRating = 5m, Comment = "Amazing quality for the price! The fabric feels soft and durable. Highly recommend this shop.", DatePost = new DateTime(2023, 4, 25) },
                new Review { ProductId = 8, ReviewRating = 2m, Comment = "The clothes were fine, but the size wasn’t right for me. I may have to return this item.", DatePost = new DateTime(2023, 3, 15) },
                new Review { ProductId = 9, ReviewRating = 4m, Comment = "Nice clothes, but the stitching could be improved. Still, I’m happy with my purchase.", DatePost = new DateTime(2023, 8, 8) },
                new Review { ProductId = 10, ReviewRating = 5m, Comment = "These clothes are exactly what I was looking for. The design and quality are excellent!", DatePost = new DateTime(2023, 2, 11) },
                new Review { ProductId = 11, ReviewRating = 3m, Comment = "Good quality overall, but the delivery took longer than expected. Still satisfied with the purchase.", DatePost = new DateTime(2023, 9, 6) },
                new Review { ProductId = 12, ReviewRating = 5m, Comment = "This is one of my favorite purchases so far! The clothes fit perfectly and look great.", DatePost = new DateTime(2023, 7, 28) }
            };



            var newReviews = reviews.Where(r => !context.Reviews.Any(dbReview => dbReview.ProductId == r.ProductId && dbReview.AppUserId == r.AppUserId)).ToList();
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

            };

            var newUserPromotions = userPromotions.Where(up => !context.UserPromotions.Any(dbUserPromotion => dbUserPromotion.AppUserId == up.AppUserId && dbUserPromotion.PromotionId == up.PromotionId)).ToList();
            if (newUserPromotions.Any())
            {
                context.UserPromotions.AddRange(newUserPromotions);
                context.SaveChanges();
            }
        }
    }
}
