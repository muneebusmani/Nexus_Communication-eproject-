using NexusCommunication.Entities;
using NexusCommunication.Models;

namespace NexusCommunication.Interfaces;

public interface ICustomerRepository : IGenericRepository<Customers>
{
    public Task<int> PlaceOrder(int id);
    public Task<Orders> CheckOrderStatus(int id);
}