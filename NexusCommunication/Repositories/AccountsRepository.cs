using NexusCommunication.Data;
using NexusCommunication.Entities;

namespace NexusCommunication.Repositories;

public class AccountsRepository : GenericRepository<AccountsDept>
{
    public AccountsRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }
}