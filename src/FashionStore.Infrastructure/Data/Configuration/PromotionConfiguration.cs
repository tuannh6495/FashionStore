using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Configuration
{
	public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
	{
		public void Configure(EntityTypeBuilder<Promotion> builder)
		{
			builder.HasKey (p => p.Id);

			builder.HasOne(p => p.Cart)
				.WithOne()
				.HasForeignKey<Promotion>(p => p.CartId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
