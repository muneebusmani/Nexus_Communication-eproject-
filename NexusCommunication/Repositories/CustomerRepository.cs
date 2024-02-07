using NexusCommunication.Data;
using NexusCommunication.Entities;
using NexusCommunication.Interfaces;
using NexusCommunication.Models;

namespace NexusCommunication.Repositories;

public class CustomerRepository : GenericRepository<Customers>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<int> PlaceOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Orders> CheckOrderStatus(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }
}