using NexusCommunication.Data;
using NexusCommunication.Interfaces;
using NexusCommunication.Repositories;

namespace NexusCommunication.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Customer = new CustomerRepository(_context);
        Employee = new EmployeeRepository(_context);
    }

    public ICustomerRepository Customer { get; }
    public IEmployeeRepository Employee { get; }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}