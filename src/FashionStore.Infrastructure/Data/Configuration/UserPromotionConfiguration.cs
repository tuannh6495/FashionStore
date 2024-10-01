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
    public class UserPromotionConfiguration : IEntityTypeConfiguration<UserPromotion>
    {
        public void Configure(EntityTypeBuilder<UserPromotion> builder)
        {
            builder.HasKey(up => up.Id);

            builder.HasOne(up => up.User)
                .WithMany(u => u.UserPromotions)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(up => up.Promotion)
                .WithMany(p => p.UserPromotions)
                .HasForeignKey(up => up.PromotionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
