using FashionStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashionStore.Infrastructure.Data.Configuration
{
    public class AppUserConfigurationcs : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(au => au.Id);

            builder.Property(au => au.DateOfBirth)
                .HasColumnType("date");

            builder.Property(au => au.Address)
                .HasColumnType("nvarchar(400)")
                .HasMaxLength(400);
        }
    }
}
