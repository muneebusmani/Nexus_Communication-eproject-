using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Orders
{
    [Required] [Key] public int OrderId { get; set; }

    [CustomValidation(typeof(Orders), "ValidateType", ErrorMessage = "Invalid Prefix")]
    [Required]
    public char OrderIdPrefix { get; set; }

    [Required] public int CustomerId { get; set; }
    [Required] public int EmployeeId { get; set; }
    [Required] public DateTime OrderDate { get; set; }
    [Required] public string Status { get; set; } = "";

    public static bool ValidateType(string OrderIdPrefix)
    {
        List<String> OrderTypes = new() { "D", "T", "B" };
        return OrderTypes.Contains(OrderIdPrefix);
    }
}