

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class OfferEntity
{
    [Key]
    public int Id { get; set; }

    
    [StringLength(100)]
    public string? SelectedService { get; set; }

   
    [StringLength(50)]
    public string? FirstName { get; set; }

  
    [StringLength(50)]
    public string? LastName { get; set; }

   
    [StringLength(20)]
    public string? OrgNumber { get; set; }

    
    [StringLength(100)]
    public string? Address { get; set; }

   
    [EmailAddress]
    [StringLength(100)]
    public string? Email { get; set; }

   
    [Phone]
    [StringLength(20)]
    public string? PhoneNumber { get; set; }

  
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
