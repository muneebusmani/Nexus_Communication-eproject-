using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace Project.Entities;

[Index(nameof(AccountId), IsUnique = true)]
public class Customers
{
    [Required] [Key] public int CustomerId { get; set; }
    [Required] public string Name { get; set; } = "";
    [Required] public string Phone { get; set; } = "";
    [Required] public string Address { get; set; } = "";
    [Required] [Length(16, 32)] public int AccountId { get; set; }
}