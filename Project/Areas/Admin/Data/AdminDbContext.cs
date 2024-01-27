using Microsoft.EntityFrameworkCore;

namespace Project.Areas.Admin.Data;

public class AdminDbContext : DbContext
{
    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {
    }
}