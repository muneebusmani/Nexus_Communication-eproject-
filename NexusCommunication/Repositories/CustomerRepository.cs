using NexusCommunication.Entities;
using NexusCommunication.Models;

namespace NexusCommunication.Repositories;

public class CustomerRepository: ICustomer
{
    public Task<int> SignUp(Entity credentials)
    {
        throw new NotImplementedException();
    }

    public Task<int> SignIn(Entity credentials)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateProfile(Entity credentials)
    {
        throw new NotImplementedException();
    }

    public Task<int> PlaceOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Orders> CheckOrderStatus(int id)
    {
        throw new NotImplementedException();
    }
}