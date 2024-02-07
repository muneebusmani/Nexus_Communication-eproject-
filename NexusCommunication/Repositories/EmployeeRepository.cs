using NexusCommunication.Data;
using NexusCommunication.Entities;
using NexusCommunication.Interfaces;

namespace NexusCommunication.Repositories;

public class EmployeeRepository(ApplicationDbContext context)
    : GenericRepository<Employees>(context), IEmployeeRepository
{
    public Task<int> SignIn(Employees credentials)
    {
        throw new NotImplementedException();
    }
}