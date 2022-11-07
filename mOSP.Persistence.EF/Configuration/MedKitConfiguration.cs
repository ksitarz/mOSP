using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mOSP.Domain.Entities;

namespace mOSP.Persistence.EF.Configuration
{
    public class MedKitConfiguration : IEntityTypeConfiguration<MedKit>
    {
        public void Configure(EntityTypeBuilder<MedKit> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();
            builder.Property(e => e.OspId)
                .IsRequired();
            builder.Property(e => e.ContainerType)
                .IsRequired();
        }
    }
}
