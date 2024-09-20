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
	public class OutPConfiguration : IEntityTypeConfiguration<OutP>
	{
		public void Configure(EntityTypeBuilder<OutP> builder)
		{
			builder.HasKey(op => op.Id);

			builder.HasOne(op => op.Outstanding)
				.WithMany(o => o.OutPs)
				.HasForeignKey(op => op.OutstandingId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(op => op.Product)
				.WithMany(p => p.OutPs)
				.HasForeignKey(op => op.ProductId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
