using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Areas.Retail.Models;

public class Connections
{
    [Key] public int ConnectionId { get; set; }
    public int CustomerId { get; set; }
    public int OrderId { get; set; }
    public string Status { get; set; } = "";
    public string ConnectionDetails { get; set; } = "";
    public string BillAmount { get; set; } = "";
    public int BillId { get; set; }
}