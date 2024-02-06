using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunication.Entities;

public class Admin:Entity
{
    [Key]
    [Required]
    [DisplayName("Admin id:")]
    public int AdminId { get; set; }

    [DisplayName("Full name:")]
    [DataType(DataType.Text)]
    [StringLength(50)]
    [Required]
    public string Name { get; set; } = "";


    [DataType(DataType.Text)]
    [StringLength(21, MinimumLength = 8, ErrorMessage = "Username Must be 8-21 characters long.")]
    [Required]
    public string Username { get; set; } = "";

    [DataType(DataType.EmailAddress)]
    [Required]
    [StringLength(100)]
    [DisplayName("Email address:")]
    public string Email { get; set; } = "";
    
    [DataType(DataType.PhoneNumber)]
    [Required]
    [DisplayName("Contact number:")]
    [StringLength(13)]
    public string Phone { get; set; } = "";
    
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 8, ErrorMessage = "Password Must be 8-40 characters long.")]
    [Required]
    public string Password { get; set; } = "";
}