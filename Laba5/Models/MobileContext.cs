using Microsoft.EntityFrameworkCore;

namespace Laba5.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobileContext(DbContextOptions<MobileContext> dbContextOptions)
            : base(dbContextOptions) 
        {
            Database.EnsureCreated();
        }
    }
}
