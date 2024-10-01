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
    public class CartPConfiguration : IEntityTypeConfiguration<CartP>
    {
        public void Configure(EntityTypeBuilder<CartP> builder)
        {
            builder.HasKey(cp => cp.Id);

            builder.HasOne(cp => cp.Cart)
                .WithMany(c => c.CartPs)
                .HasForeignKey(cp => cp.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cp => cp.Product)
                .WithMany(p => p.CartPs)
                .HasForeignKey(cp => cp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
