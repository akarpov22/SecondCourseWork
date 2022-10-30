using Microsoft.EntityFrameworkCore;

namespace CourseWorkServer.Models.DbContexts
{
    public class AppDbContext : DbContext
    {
        public const string connectionString = "Server=DESKTOP-BKRH9MN;" +
                                               "Database=CourseWorkDataBase;" +
                                               "Trusted_Connection=True;" +
                                               "MultipleActiveResultSets=True";
        public AppDbContext()
            : base(SqlServerDbContextOptionsExtensions
                  .UseSqlServer(
                                new DbContextOptionsBuilder(),
                                connectionString).Options
                  )
        {
            Database.EnsureCreated();
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Deliver> Delivers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Orders_Products> Orders_Products { get; set; }
    }
}