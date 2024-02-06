using NexusCommunication.Entities;
using NexusCommunication.Repositories.Interfaces;

namespace NexusCommunication.Repositories;

public class BaseRepository:IBase
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
}