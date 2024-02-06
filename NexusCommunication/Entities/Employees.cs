using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Entities;

public class Employees:Entity
{
    [Required]
    [Key]
    [DisplayName("Employee id:")]
    public int EmployeeId { get; set; }

    [DisplayName("Employee name:")]
    [Required]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Role Is Necessary to Register an Employee")]
    [CustomValidation(typeof(Employees), "ValidateRole", ErrorMessage = "Invalid role.")]
    public string Role { get; set; } = "";

    [Required] public string Phone { get; set; } = "";
    [Required] public string Username { get; set; } = "";
    [Required] public string Password { get; set; } = "";

    private static bool ValidateRole(string Role)
    {
        List<String> roles = new() { "Accounts", "Admin", "Retail" };
        return roles.Contains(Role);
    }
}