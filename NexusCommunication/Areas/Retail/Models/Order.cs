namespace NexusCommunication.Areas.Retail.Models;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int AccountId { get; set; }
    public string Status { get; set; }
    public string? Email { get; set; }
}