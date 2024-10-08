using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Data.Configuration
{
    public class ColorPConfiguration : IEntityTypeConfiguration<ColorP>
    {
        public void Configure(EntityTypeBuilder<ColorP> builder)
        {
            builder.HasKey(cp => cp.Id);

            builder.HasOne(cp => cp.Color)
                .WithMany(c => c.ColorPs)
                .HasForeignKey(cp => cp.ColorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cp => cp.Product)
                .WithMany(p => p.ColorPs)
                .HasForeignKey(cp => cp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
