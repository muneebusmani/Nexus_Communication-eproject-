using NexusCommunication.Data;
using NexusCommunication.Entities;

namespace NexusCommunication.Repositories;

public class RetailRepository : GenericRepository<RetailDept>
{
    public RetailRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }
}