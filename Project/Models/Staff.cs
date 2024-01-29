using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Staff : StaffBase
{
    public StaffRole Role { get; set; }
}