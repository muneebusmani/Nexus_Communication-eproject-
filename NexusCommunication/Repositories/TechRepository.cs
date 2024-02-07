using NexusCommunication.Data;
using NexusCommunication.Entities;

namespace NexusCommunication.Repositories;

public class TechRepository : GenericRepository<TechDept>
{
    public TechRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }
}