using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Admin
{
    [Key]
    [Required]
    [DisplayName("Admin id:")]
    public int AdminId { get; set; }

    [DisplayName("Full name:")]
    [DataType(DataType.Text)]
    [Required]
    public string Name { get; set; } = "";


    [DataType(DataType.Text)]
    [StringLength(21, MinimumLength = 8, ErrorMessage = "Username Must be 8-21 characters long.")]
    [Required]
    public string Username { get; set; } = "";

    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    [Required]
    [DisplayName("Email address:")]
    public string Email { get; set; } = "";

    [Phone]
    [DataType(DataType.PhoneNumber)]
    [Required]
    [DisplayName("Contact number:")]
    public string Phone { get; set; } = "";

    [PasswordPropertyText]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Must be 8-40 characters long.")]
    [Required]
    public string Password { get; set; } = "";
}