using NexusCommunication.Models;

namespace NexusCommunication.Repositories.Interfaces;

public interface IAccounts:IBase
{
    public abstract Task<int> CreateBill(Billing bill);
    public abstract Task<int> UpdateBill(Billing bill);
    public abstract Task<Billing> SearchBill(Billing bill);
}