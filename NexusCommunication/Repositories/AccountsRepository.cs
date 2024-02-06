using NexusCommunication.Entities;
using NexusCommunication.Models;
using NexusCommunication.Repositories.Interfaces;

namespace NexusCommunication.Repositories;

public class AccountsRepository:IAccounts
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

    public Task<int> CreateBill(Billing bill)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateBill(Billing bill)
    {
        throw new NotImplementedException();
    }

    public Task<Billing> SearchBill(Billing bill)
    {
        throw new NotImplementedException();
    }
}