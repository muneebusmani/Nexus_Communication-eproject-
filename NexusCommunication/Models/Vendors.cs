using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Vendors
{
    [Key] public int VendorId { get; set; }
    [Required] public string Name { get; set; } = "";
    [Required] public string ContactDetails { get; set; } = "";
}