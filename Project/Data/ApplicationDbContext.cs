using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Project.Models;

namespace Project.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Staff>().ToTable(t => t.HasCheckConstraint("CK_Role",
            "[Role] IN ('Account', 'Admin', 'Retail', 'User')"));

        modelBuilder.Entity<Admin>().HasData(new Admin
            {
                AdminId = 1,
                Name = "Master Admin",
                Password = "<SecretPasswordOfMasterAdmin>",
                Username = "MasterAdmin1234",
                Email = "masteradmin@gmail.com",
                Phone = "03012345678"
            }
        );
    }*/

    public DbSet<Admin> Admin { get; set; }
    public DbSet<Billing> Billing { get; set; }
    public DbSet<Charges> Charges { get; set; }
    public DbSet<Connections> Connections { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Plans> Plans { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<RetailShops> RetailShops { get; set; }
    public DbSet<Vendors> Vendors { get; set; }
}