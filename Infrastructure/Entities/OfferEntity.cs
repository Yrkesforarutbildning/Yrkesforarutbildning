

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

public class OfferEntity
{
    [Key]
    public int Id { get; set; }


    [StringLength(100)]
    public string SelectedService { get; set; } = null!;

   
    [StringLength(50)]
    public string FirstName { get; set; } = null!;


    [StringLength(50)]
    public string LastName { get; set; } = null!;


    [StringLength(20)]
    public string OrgNumber { get; set; } = null!;


    [StringLength(100)]
    public string Address { get; set; } = null!;



    [StringLength(100)]
    public string Email { get; set; } = null!;

    public string ChooseDate { get; set; } = null!;


    [Phone]
    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;


    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
