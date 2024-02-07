using NexusCommunication.Data;
using NexusCommunication.Entities;
using NexusCommunication.Interfaces;
using NexusCommunication.Models;

namespace NexusCommunication.Repositories;

public class CustomerRepository(ApplicationDbContext context)
    : GenericRepository<Customers>(context), ICustomerRepository
{
    public Task<int> PlaceOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Orders> CheckOrderStatus(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> SignIn(Customers credentials)
    {
        throw new NotImplementedException();
    }
}