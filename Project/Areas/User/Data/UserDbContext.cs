using Microsoft.EntityFrameworkCore;

namespace Project.Areas.User.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }
}