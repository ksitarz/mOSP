using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mOSP.Domain.Entities;
using System;

namespace mOSP.Persistence.EF.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Email)
                .IsRequired();
            builder.Property(e => e.FirstName)
                .IsRequired();
            builder.Property(e => e.LastName)
                .IsRequired();
            builder.Property(e => e.Email)
                .IsRequired();
            builder.Property(e => e.PasswordHash)
                .IsRequired();
            builder.Property(e => e.RoleID)
                .IsRequired();
        }
    }
}
