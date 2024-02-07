using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace NexusCommunication.Entities;

[Index(nameof(AccountId), IsUnique = true)]
public class Customers
{
    [Required] public int Id { get; set; }

    [Required]
    [StringLength(255)]
    [DisplayName("Full name:")]
    public string? Name { get; set; } = "";

    [Required]
    [StringLength(21, MinimumLength = 8, ErrorMessage = "Username Must be 8-21 characters long.")]
    public string? Username { get; set; } = "";

    [Required]
    [StringLength(100)]
    [DisplayName("Email address:")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; } = "";

    [Required]
    [StringLength(13)]
    [DisplayName("Contact number:")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; } = "";

    [Required]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Must be 8-40 characters long.")]
    public string? Password { get; set; } = "";

    [StringLength(255)] [Required] public string? Address { get; set; } = "";

    [Required] [Length(16, 32)] public int AccountId { get; set; }
}