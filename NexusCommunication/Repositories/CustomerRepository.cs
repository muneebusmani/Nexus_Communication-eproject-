using NexusCommunication.Entities;
using NexusCommunication.Models;
using NexusCommunication.Repositories.Interfaces;

namespace NexusCommunication.Repositories;

public class CustomerRepository:BaseRepository, ICustomer
{
    

    public Task<int> PlaceOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Orders> CheckOrderStatus(int id)
    {
        throw new NotImplementedException();
    }
}