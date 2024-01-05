using System.Reflection;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Data.EF;

public class EShopDbContext : DbContext
{
    public EShopDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Product> Products;
    public DbSet<Category> Categories;
    public DbSet<Order> Orders;
    public DbSet<OrderDetail> OrderDetails;
    public DbSet<Contact> Contacts;

}