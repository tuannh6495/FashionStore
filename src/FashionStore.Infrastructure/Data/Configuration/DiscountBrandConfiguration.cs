using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Data.Configuration
{
    public class DiscountBrandConfiguration : IEntityTypeConfiguration<DiscountBrand>
    {
        public void Configure(EntityTypeBuilder<DiscountBrand> builder)
        {
            builder.HasKey(db => db.Id);

            builder.HasOne(db => db.Discount)
                .WithMany(d => d.DiscountBrands)
                .HasForeignKey(db => db.DiscountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(db => db.Brand)
                .WithMany(b => b.DiscountBrands)
                .HasForeignKey(db => db.BrandId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
