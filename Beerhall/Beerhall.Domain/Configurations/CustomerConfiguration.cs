using Beerhall.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Beerhall.Infrastructure.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.OwnsOne(x => x.Address).Property(x => x.Street).HasColumnName(nameof(Address.Street));
            builder.OwnsOne(x => x.Address).Property(x => x.Country).HasColumnName(nameof(Address.Country));
        }
    }
}
