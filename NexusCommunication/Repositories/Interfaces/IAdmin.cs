using NexusCommunication.Models;

namespace NexusCommunication.Repositories.Interfaces;

public interface IAdmin:IBase
{
    public abstract Task<List<Plans>> GetPlans();
    public abstract Task<Plans> GetPlansById(int id);
    public abstract Task<Plans> GetPlansByName(string name);
    public abstract Task<int> AddPlan(Plans plan);
    public abstract Task<int> UpdatePlan(int id);
    public abstract Task<int> UpdatePlanDescription(int id, string description);
    public abstract Task<int> UpdatePlanName(int id, string name);
    public abstract Task<int> UpdatePlanCharges(int id, string charges);
    public abstract Task<int> UpdatePlanLimit(int id, string limit);
    public abstract Task<int> UpdatePlanSpeed(int id, string speed);
    public abstract Task<int> DeletePlan(int id);
}