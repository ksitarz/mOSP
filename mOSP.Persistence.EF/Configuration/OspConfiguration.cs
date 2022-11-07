using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mOSP.Domain.Entities;

namespace mOSP.Persistence.EF.Configuration
{
    public class OspConfiguration : IEntityTypeConfiguration<OSP>
    {
        public void Configure(EntityTypeBuilder<OSP> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();
        }

    }
}
