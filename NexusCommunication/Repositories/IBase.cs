using NexusCommunication.Entities;

namespace NexusCommunication.Repositories;

public interface IBase
{
    public abstract Task<int> SignUp(Entity credentials);
    public abstract Task<int> SignIn(Entity credentials);
    public abstract Task<int> UpdateProfile(Entity credentials);
    
}