using MecanicNew.Model;
using Microsoft.EntityFrameworkCore;

namespace MecanicNew.SqlData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RepairSelects> RepairSelects { get; set; }
        public DbSet<RepairTotalPrices> RepairTotalPrices { get; set; }
        public DbSet<Model.Type> Types { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RepairDesciription> RepairDesciription { get; set; }


    }
}
