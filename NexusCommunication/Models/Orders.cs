using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Models;

public class Orders
{
    [Key] public int OrderId { get; set; }

    [CustomValidation(typeof(Orders), "ValidateType", ErrorMessage = "Invalid Prefix, choose one from D ,T ,B")]
    [Required]
    public char OrderIdPrefix { get; set; }

    [Required] public int CustomerId { get; set; }
    [Required] public int EmployeeId { get; set; }
    [Required] public DateTime OrderDate { get; set; }
    [Required] public string Status { get; set; } = "";

    public static bool ValidateType(string OrderIdPrefix)
    {
        List<String> orderTypes = ["D", "T", "B"];
        return orderTypes.Contains(OrderIdPrefix);
    }
}