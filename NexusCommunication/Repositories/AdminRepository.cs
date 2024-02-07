using NexusCommunication.Data;
using NexusCommunication.Entities;

namespace NexusCommunication.Repositories;

public class AdminRepository : GenericRepository<Admin>
{
    public AdminRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }
}