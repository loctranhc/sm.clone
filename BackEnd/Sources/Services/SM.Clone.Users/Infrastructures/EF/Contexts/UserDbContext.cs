using Domains.Entities;
using Infrastructures.EF.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.EF.Contexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PhoneType> PhoneTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            UserDbSeed.SeedAddressType(modelBuilder);
            UserDbSeed.SeedPhoneType(modelBuilder);
        }
    }
}