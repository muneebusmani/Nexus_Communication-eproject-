using Microsoft.EntityFrameworkCore;

using NexusCommunication.Entities;
using NexusCommunication.Models;

namespace NexusCommunication.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }


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