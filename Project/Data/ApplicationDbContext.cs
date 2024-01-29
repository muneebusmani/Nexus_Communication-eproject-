using Microsoft.EntityFrameworkCore;

using Project.Models;

namespace Project.Data;

using Areas.Admin.Models;
using Areas.Accounts.Models;
using Areas.Retail.Models;
using Areas.User.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Staff>().ToTable(t => t.HasCheckConstraint("CK_Role", ""));
// Convert enum to string in the database
    }

    public DbSet<Admin> Admin { get; set; }
    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Retail> Retail { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Staff> Staff { get; set; }
}