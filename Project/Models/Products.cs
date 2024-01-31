using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class Products
{
    [DisplayName("Product id:")] [Key] public int ProductId { get; set; }
    [DisplayName("Vendor id:")] public int VendorId { get; set; }
    [Required] public string Name { get; set; } = "";
    [Required] public string Description { get; set; } = "";
    [Required] public string Quantity { get; set; } = "";
}