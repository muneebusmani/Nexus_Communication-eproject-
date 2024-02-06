using NexusCommunication.Models;

namespace NexusCommunication.Repositories.Interfaces;

public interface ICustomer:IBase
{
    public abstract Task<int> PlaceOrder(int id);   
    public abstract Task<Orders> CheckOrderStatus(int id);
}