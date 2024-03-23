using Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures.EF.Seeds
{
    public static class UserDbSeed
    {
        public static void SeedPhoneType(ModelBuilder builder)
        {
            builder.Entity<PhoneType>().HasData(
                new {
                    Id = 1,
                    Name = "Home"
                },
                new {
                    Id = 2,
                    Name = "Work"
                }
            );
        }

        public static void SeedAddressType(ModelBuilder builder)
        {
            builder.Entity<AddressType>().HasData(
                new {
                    Id = 1,
                    Name = "Home"
                },
                new {
                    Id = 2,
                    Name = "Work"
                },
                new {
                    Id = 3,
                    Name = "Option"
                }
            );
        }
    }
}