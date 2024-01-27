using Microsoft.EntityFrameworkCore;

namespace Project.Areas.Retail.Data;

public class RetailDbContext : DbContext
{
    public RetailDbContext(DbContextOptions<RetailDbContext> options)
        : base(options)
    {
    }
}