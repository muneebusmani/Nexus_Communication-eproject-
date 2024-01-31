using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Charges
{
    [Required] [Key] public int ChargeId { get; set; }
    [Required] public string ConnectionType { get; set; } = "";
    [Required] public string PlanDetails { get; set; } = "";
    [Required] public float SecurityDeposit { get; set; }
}