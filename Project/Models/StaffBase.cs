using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class StaffBase
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Username { get; set; }

    [DataType(DataType.EmailAddress)] public string Email { get; set; }

    [DataType(DataType.PhoneNumber)] public string PhoneNumber { get; set; }

    [DataType(DataType.Password)] public string Password { get; set; }
}