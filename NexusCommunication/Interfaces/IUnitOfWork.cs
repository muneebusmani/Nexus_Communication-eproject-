namespace NexusCommunication.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ICustomerRepository Customer { get; }
    IEmployeeRepository Employee { get; }
    int Complete();
}