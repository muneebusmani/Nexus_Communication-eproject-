using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace Project.Models;

[Index(nameof(Email), nameof(PhoneNumber), IsUnique = true)]
public class Staff
{
    public int Id { get; set; }
    [Required] public required string FullName { get; set; } = "";

    [Required]
    [StringLength(21, ErrorMessage = "Username must be between 8 - 21 characters", MinimumLength = 8)]
    public required string Username { get; set; } = "";

    [Required]
    [EmailAddress(ErrorMessage = "Email is invalid")]
    public required string Email { get; set; } = "";

    [Required]
    [Phone(ErrorMessage = "Phone number is invalid")]
    public required string PhoneNumber { get; set; } = "";

    [Required] [PasswordPropertyText] public required string Password { get; set; } = "";

    [Required(ErrorMessage = "Role Is Necessary to Register yourself")]
    [CustomValidation(typeof(Staff), "ValidateRole", ErrorMessage = "Invalid role.")]

    public required string Role { get; set; } = "";

    public static bool ValidateRole(string Role)
    {
        List<String> roles = new() { "Accounts", "Admin", "Retail", "User" };
        return roles.Contains(Role);
    }
}