using Microsoft.EntityFrameworkCore;
using mOSP.Domain.Entities;
using mOSP.Persistence.EF.DummyData;
using mOSP.Persistence.EF.Seeder;

namespace mOSP.Persistence.EF
{
    public class mOSPContext : DbContext
    {

        public mOSPContext(DbContextOptions<mOSPContext> options) : base(options)
        {      
        }

        public DbSet<OSP> Osps { get; set; }
        public DbSet<MedKit> MedKits { get; set; }
        public DbSet<MedItem> MedItems { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(mOSPContext).Assembly);

            foreach (var item in RoleSeeder.Get())
            {
                modelBuilder.Entity<Role>().HasData(item);
            }

            foreach (var item in DummyMedItem.Get())
            {
                modelBuilder.Entity<MedItem>().HasData(item);
            }

            foreach (var item in DummyMedKit.Get())
            {
                modelBuilder.Entity<MedKit>().HasData(item);
            }

            foreach (var item in DummyOSP.Get())
            {
                modelBuilder.Entity<OSP>().HasData(item);
            }
        }
    }
}
