using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Feedback
{
    [Required] [Key] public int FeedbackId { get; set; }
    [Required] public int CustomerId { get; set; }
    [Required] public int OrderId { get; set; }
    [Required] public int EmployeeId { get; set; }
    [Required] public string FeedbackDetails { get; set; } = "";
}