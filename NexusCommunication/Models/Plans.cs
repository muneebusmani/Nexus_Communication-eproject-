using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Plans
{
    [Key] [Required] public int PlanId { get; set; }
    [Required] public string PlanName { get; set; } = "";
    [Required] public string Description { get; set; } = "";
    [Required] public float Charges { get; set; }
    [Required] public float Limit { get; set; }
    [Required] public float Speed { get; set; }
}