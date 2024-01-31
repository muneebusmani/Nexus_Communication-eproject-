using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class RetailShops
{
    [Key] public string ShopId { get; set; } = "";
    [Required] public string Location { get; set; } = "";
    [Required] public string Contact { get; set; } = "";
}