using Beerhall.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beerhall.Infrastructure.Configurations
{
    internal class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.HasMany(x => x.Beers)
                   .WithOne()
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
            builder.OwnsOne(x => x.Address).Property(x => x.Street).HasColumnName(nameof(Address.Street));
            builder.OwnsOne(x => x.Address).Property(x => x.Country).HasColumnName(nameof(Address.Country));
        }
    }
}
