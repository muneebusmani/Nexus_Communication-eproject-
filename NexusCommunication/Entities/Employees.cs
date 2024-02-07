using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Entities;

public class Employees
{
    [Required] public int Id { get; set; }

    [Required]
    [StringLength(255)]
    [DisplayName("Full name:")]
    public string? Name { get; set; }

    [Required]
    [StringLength(21, MinimumLength = 8, ErrorMessage = "Username Must be 8-21 characters long.")]
    public string? Username { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Email address:")]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }

    [Required]
    [StringLength(13)]
    [DisplayName("Contact number:")]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Must be 8-40 characters long.")]
    public string? Password { get; set; }

    [StringLength(255)]
    [Required(ErrorMessage = "Role Is Necessary to Register an Employee")]
    [CustomValidation(typeof(Employees), "ValidateRole", ErrorMessage = "Invalid role.")]
    public string? Role { get; set; }

    private static bool ValidateRole(string Role)
    {
        List<String> roles = ["Accounts", "Admin", "Retail", "Tech"];
        return roles.Contains(Role);
    }
}