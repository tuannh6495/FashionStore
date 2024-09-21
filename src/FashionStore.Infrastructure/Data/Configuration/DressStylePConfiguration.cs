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
    public class DressStylePConfiguration : IEntityTypeConfiguration<DressStyleP>
    {
        public void Configure(EntityTypeBuilder<DressStyleP> builder)
        {
            builder.HasKey(dsp => dsp.Id);

            builder.HasOne(dsp => dsp.DressStyle)
                .WithMany(ds => ds.DressStylePs)
                .HasForeignKey(dsp => dsp.DressStyleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(dsp => dsp.Product)
                .WithMany(p => p.DressStylePs)
                .HasForeignKey(dsp => dsp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
