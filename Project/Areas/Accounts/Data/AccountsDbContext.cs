using Microsoft.EntityFrameworkCore;

namespace Project.Areas.Accounts.Data;

using Models;

public class AccountsDbContext : DbContext
{
    public AccountsDbContext(DbContextOptions<AccountsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Accounts> Accounts { get; set; }
}