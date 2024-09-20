using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Configuration
{
	public class DiscountProductConfiguration : IEntityTypeConfiguration<DiscountProduct>
	{
		public void Configure(EntityTypeBuilder<DiscountProduct> builder)
		{
			builder.HasKey(dp => dp.Id);

			builder.HasOne(dp => dp.Discount)
				.WithMany(d => d.DiscountProducts)
				.HasForeignKey(dp => dp.DiscountId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(dp => dp.Product)
				.WithMany(p => p.DiscountProducts)
				.HasForeignKey(dp => dp.ProductId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
