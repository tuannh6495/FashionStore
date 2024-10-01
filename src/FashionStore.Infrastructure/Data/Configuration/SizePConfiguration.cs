using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Data.Configuration
{
    public class SizePConfiguration : IEntityTypeConfiguration<SizeP>
    {
        public void Configure(EntityTypeBuilder<SizeP> builder)
        {
            builder.HasKey(sp => sp.Id);

            builder.HasOne(sp => sp.Size)
                .WithMany(s => s.SizePs)
                .HasForeignKey(sp => sp.SizeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sp => sp.Product)
                .WithMany(p => p.SizePs)
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
