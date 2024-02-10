using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Billing
{
    [Required] [Key] public int BillId { get; set; }
    [Required] public string CustomerId { get; set; } = "";
    [Required] public string OrderId { get; set; } = "";
    [Required] public string BillAmount { get; set; } = "";
}