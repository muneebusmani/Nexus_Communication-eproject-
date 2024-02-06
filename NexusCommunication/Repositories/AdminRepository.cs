using Microsoft.AspNetCore.Mvc;

using NexusCommunication.Entities;
using NexusCommunication.Models;
using NexusCommunication.Repositories.Interfaces;

namespace NexusCommunication.Repositories;

public class AdminRepository : IAdmin
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

    public Task<List<Plans>> GetPlans()
    {
        throw new NotImplementedException();
    }

    public Task<Plans> GetPlansById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Plans> GetPlansByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddPlan(Plans plan)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlan(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlanDescription(int id, string description)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlanName(int id, string name)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlanCharges(int id, string charges)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlanLimit(int id, string limit)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdatePlanSpeed(int id, string speed)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeletePlan(int id)
    {
        throw new NotImplementedException();
    }
}