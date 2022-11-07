using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mOSP.Domain.Entities;

namespace mOSP.Persistence.EF.Configuration
{
    public class MedItemConfiguration : IEntityTypeConfiguration<MedItem>
    {
        public void Configure(EntityTypeBuilder<MedItem> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();
            builder.Property(e => e.ExpirationDate)
                .IsRequired();
        }
    }
}
