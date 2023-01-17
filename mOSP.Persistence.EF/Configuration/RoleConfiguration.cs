using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mOSP.Domain.Entities;

namespace mOSP.Persistence.EF.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
