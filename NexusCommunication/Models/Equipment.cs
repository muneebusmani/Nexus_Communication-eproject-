using Microsoft.Build.Framework;

namespace NexusCommunication.Models;

public class Equipment
{
    public int Id { get; set; }

    [Required] public string Name { get; set; }

    [Required] public string Description { get; set; }

    [Required] public string Category { get; set; }
}