using FastOrder.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FastOrder.Domain.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}


        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Item> Item { get; set; } = null!;
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set;}
        public DbSet<OrderItem> OrderItem { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);

    }

}
