using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Data
{
    public class FosDbContext : DbContext
    {
		public FosDbContext(DbContextOptions<FosDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<DressStyle> DressStyles { get; set; }
		public DbSet<DressStyleP> DressStylePs { get; set; }
		public DbSet<Outstanding> Outstandings { get; set; }
		public DbSet<OutP> OutPs { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<SizeP> SizePs { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<ColorP> ColorPs { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<CartP> CartPs { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<DiscountType> DiscountTypes { get; set; }
		public DbSet<Discount> Discounts { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<UserPromotion> UserPromotions { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
    }
}
