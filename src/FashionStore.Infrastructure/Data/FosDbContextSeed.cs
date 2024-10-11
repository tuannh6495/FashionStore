using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
                //Hoodie
                new Product(new List<string> { "/Images/Hoodie/Dioramour Hooded Anorak/back.webp", "/Images/Hoodie/Dioramour Hooded Anorak/fore.webp", "/Images/Hoodie/Dioramour Hooded Anorak/model.webp" }, "Dioramour Hooded Anorak")
                {
                    Price = 4050,
                    Description = "Part of the Dioramour capsule, the hooded anorak showcases the black and red Je Vous Adore (I Love You) motif, inspired by the Marc Bohan for Dior archives. Crafted in white technical taffeta jacquard, it features a zip closure and four snap pockets on the front, including two with flaps, while drawstring cords at the bottom offer an optimal fit. The laid-back anorak can be paired with other Dioramour creations to complete the look.",
                    AvgRating = 4.5m,
                    CategoryId = 4,
                    Gender = 1,
                    DiscountId = 25
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
                    DiscountId = 33
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
                    DiscountId = 17
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
                    DiscountId = 44
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
                    DiscountId = 13
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
                    DiscountId = 32
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
                    DiscountId = 10
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
                    DiscountId = 25
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
                    DiscountId = 13
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
                    DiscountId = 18
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
                    DiscountId = 25
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
                    DiscountId = 9
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
                    DiscountId = 11
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
                    DiscountId = 56
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
                    DiscountId = 27
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
                    DiscountId = 70
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
                    DiscountId = 13
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
                    DiscountId = 21
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
                    DiscountId = 49
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
                    Description = "",
                    AvgRating = 4.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 15
                },
                new Product(new List<string> { "/Images/Shorts/Denim Shorts/back.avif", "/Images/Shorts/Denim Shorts/fore.avif", "/Images/Shorts/Denim Shorts/model.avif" }, "Denim Shorts")
                {
                    Price = 3000,
                    Description = "",
                    AvgRating = 3.5m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 22
                },
                new Product(new List<string> { "/Images/Shorts/Denim Shorts With Horsebit Details/back.avif", "/Images/Shorts/Denim Shorts With Horsebit Details/fore.avif", "/Images/Shorts/Denim Shorts With Horsebit Details/model.avif" }, "Denim Shorts With Horsebit Details")
                {
                    Price = 3400,
                    Description = "",
                    AvgRating = 4.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 30
                },
                new Product(new List<string> { "/Images/Shorts/GG Canvas Shorts/back.avif", "/Images/Shorts/GG Canvas Shorts/fore.jpg", "/Images/Shorts/GG Canvas Shorts/model.jpg" }, "GG Canvas Shorts")
                {
                    Price = 4000,
                    Description = "",
                    AvgRating = 4.5m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 10
                },
                new Product(new List<string> { "/Images/Shorts/GG Embossed Leather Short/back.avif", "/Images/Shorts/GG Embossed Leather Short/fore.avif", "/Images/Shorts/GG Embossed Leather Short/model.avif" }, "GG Embossed Leather Short")
                {
                    Price = 5000,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/GG Supreme Silk Shorts/back.avif", "/Images/Shorts/GG Supreme Silk Shorts/fore.avif", "/Images/Shorts/GG Supreme Silk Shorts/model.avif" }, "GG Supreme Silk Shorts")
                {
                    Price = 7216,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Lace 20s Denim Short/back.webp", "/Images/Shorts/Lace 20s Denim Short/fore.webp", "/Images/Shorts/Lace 20s Denim Short/model.webp" }, "Lace 20s Denim Short")
                {
                    Price = 3055,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Light Wool Crêpe Shorts/back.avif", "/Images/Shorts/Light Wool Crêpe Shorts/fore.avif", "/Images/Shorts/Light Wool Crêpe Shorts/model.avif" }, "Light Wool Crêpe Shorts")
                {
                    Price = 5546,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/back.avif", "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/fore.avif", "/Images/Shorts/Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite/model.avif" }, "Men's Unity Sports Icon Basketball Shorts In Dark Bluewhite")
                {
                    Price = 4671,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Minimal Cargo Shorts In Black/back.avif", "/Images/Shorts/Minimal Cargo Shorts In Black/fore.avif", "/Images/Shorts/Minimal Cargo Shorts In Black/model.avif" }, "Minimal Cargo Shorts In Black")
                {
                    Price = 6105,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Outline Arrow Linen Short/back.webp", "/Images/Shorts/Outline Arrow Linen Short/fore.jpg", "/Images/Shorts/Outline Arrow Linen Short/model.webp" }, "Outline Arrow Linen Short")
                {
                    Price = 3410,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Poplin Ow Embr Baseball Short/back.jpg", "/Images/Shorts/Poplin Ow Embr Baseball Short/fore.jpg", "/Images/Shorts/Poplin Ow Embr Baseball Short/model.webp" }, "Poplin Ow Embr Baseball Short")
                {
                    Price = 7506,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Printed Silk Twill Shorts/back.jpg", "/Images/Shorts/Printed Silk Twill Shorts/fore.avif", "/Images/Shorts/Printed Silk Twill Shorts/model.jpg" }, "Printed Silk Twill Shorts")
                {
                    Price = 6273,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Tweed Blend Shorts/back.avif", "/Images/Shorts/Tweed Blend Shorts/fore.avif", "/Images/Shorts/Tweed Blend Shorts/model.webp" }, "Tweed Blend Shorts")
                {
                    Price = 4448,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Women's Activewear Cycling Shorts In Black/back.avif", "/Images/Shorts/Women's Activewear Cycling Shorts In Black/fore.avif", "/Images/Shorts/Women's Activewear Cycling Shorts In Black/model.avif" }, "Women's Activewear Cycling Shorts In Black")
                {
                    Price = 5114,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/Shorts/Wool Mohair Bermuda Shorts/back.avif", "/Images/Shorts/Wool Mohair Bermuda Shorts/fore.avif", "/Images/Shorts/Wool Mohair Bermuda Shorts/model.avif" }, "Wool Mohair Bermuda Shorts")
                {
                    Price = 7761,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 2,
                    Gender = 1,
                    DiscountId = 5
                },

                //T-Shirt
                new Product(new List<string> { "/Images/T-Shirt/Asymmetric Ribbed T-shirt/back.webp", "/Images/T-Shirt/Asymmetric Ribbed T-shirt/fore.webp", "/Images/T-Shirt/Asymmetric Ribbed T-shirt/model.webp" }, "Asymmetric Ribbed T-shirt")
                {
                    Price = 5950,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Basic Training T-shirt/back.webp", "/Images/T-Shirt/Basic Training T-shirt/fore.webp", "/Images/T-Shirt/Basic Training T-shirt/model.webp" }, "Basic Training T-shirt")
                {
                    Price = 5732,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/back.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/fore.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Embroidery/model.avif" }, "Cotton Jersey T-shirt With Embroidery")
                {
                    Price = 4967,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/back.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/fore.avif", "/Images/T-Shirt/Cotton Jersey T-shirt With Interlocking G/model.avif" }, "Cotton Jersey T-shirt With Interlocking G")
                {
                    Price = 3961,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Cotton T-shirt With Belt/back.webp", "/Images/T-Shirt/Cotton T-shirt With Belt/fore.webp", "/Images/T-Shirt/Cotton T-shirt With Belt/model.webp" }, "Cotton T-shirt With Belt")
                {
                    Price = 6670,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Men's T-shirt Oversized In Black/back.avif", "/Images/T-Shirt/Men's T-shirt Oversized In Black/fore.avif", "/Images/T-Shirt/Men's T-shirt Oversized In Black/model.avif" }, "Men's T-shirt Oversized In Black")
                {
                    Price = 6859,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/back.webp", "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/fore.webp", "/Images/T-Shirt/Monogram Logo Overlay Graphic Classic T-shirt/model.webp" }, "Monogram Logo Overlay Graphic Classic T-shirt")
                {
                    Price = 6962,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Polyamide T-shirt/back.jpg", "/Images/T-Shirt/Polyamide T-shirt/fore.webp", "/Images/T-Shirt/Polyamide T-shirt/model.jpg" }, "Polyamide T-shirt")
                {
                    Price = 3746,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Regular Fit Interlock T-shirt/back.webp", "/Images/T-Shirt/Regular Fit Interlock T-shirt/fore.webp", "/Images/T-Shirt/Regular Fit Interlock T-shirt/model.webp" }, "Regular Fit Interlock T-shirt")
                {
                    Price = 3475,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/back.webp", "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/fore.webp", "/Images/T-Shirt/Ribbed Long Sleeve T-shirt/model.webp" }, "Ribbed Long Sleeve T-shirt")
                {
                    Price = 6250,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Striped Heavy Cotton T-shirt/back.webp", "/Images/T-Shirt/Striped Heavy Cotton T-shirt/fore.webp", "/Images/T-Shirt/Striped Heavy Cotton T-shirt/model.jpg" }, "Striped Heavy Cotton T-shirt")
                {
                    Price = 4037,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Striped Oversize T-shirt/back.webp", "/Images/T-Shirt/Striped Oversize T-shirt/fore.webp", "/Images/T-Shirt/Striped Oversize T-shirt/model.webp" }, "Striped Oversize T-shirt")
                {
                    Price = 7197,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Textured Jacquard T-shirt/back.jpg", "/Images/T-Shirt/Textured Jacquard T-shirt/fore.webp", "/Images/T-Shirt/Textured Jacquard T-shirt/model.jpg" }, "Textured Jacquard T-shirt")
                {
                    Price = 6926,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Viscose Long Sleeve T-shirt/back.webp", "/Images/T-Shirt/Viscose Long Sleeve T-shirt/fore.webp", "/Images/T-Shirt/Viscose Long Sleeve T-shirt/model.webp" }, "Viscose Long Sleeve T-shirt")
                {
                    Price = 4757,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/V-neck Ribbed T-shirt/back.webp", "/Images/T-Shirt/V-neck Ribbed T-shirt/fore.webp", "/Images/T-Shirt/V-neck Ribbed T-shirt/model.webp" }, "V-neck Ribbed T-shirt")
                {
                    Price = 4195,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/back.avif", "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/fore.avif", "/Images/T-Shirt/Women's Activewear T-shirt Fitted In Black/model.avif" }, "Women's Activewear T-shirt Fitted In Black")
                {
                    Price = 5102,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 1,
                    DiscountId = 5
                },
                new Product(new List<string> { "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/back.jpg", "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/fore.avif", "/Images/T-Shirt/Women's Ciao Bello Shrunk T-shirt In Black/model.avif" }, "Women's Ciao Bello Shrunk T-shirt In Black")
                {
                    Price = 4667,
                    Description = "",
                    AvgRating = 5.0m,
                    CategoryId = 1,
                    Gender = 0,
                    DiscountId = 5
                },
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
