using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Connections
{
    [Required] [Key] public int ConnectionId { get; set; }
    [Required] public int CustomerId { get; set; }
    [Required] public int OrderId { get; set; }
    [Required] public string Status { get; set; } = "";
    [Required] public string ConnectionDetails { get; set; } = "";
}