using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FashionStore.Infrastructure.Data.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.AppUser)
                .WithOne()
                .HasForeignKey<Cart>(c => c.AppUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
