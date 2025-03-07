using System.ComponentModel.DataAnnotations;

namespace Yrkesforarutbildning.Models;

public class OfferModel
{
    
    [Display(Name = "Vald tjänst")]
    public string? SelectedService { get; set; } 

    
    [StringLength(50, ErrorMessage = "Förnamn får inte vara längre än 50 tecken")]
    [Display(Name = "Förnamn")]
    public string? FirstName { get; set; }

    
    [StringLength(50, ErrorMessage = "Efternamn får inte vara längre än 50 tecken")]
    [Display(Name = "Efternamn")]
    public string? LastName { get; set; }

    
    [StringLength(20, ErrorMessage = "Organisationsnummer/Personnummer får inte vara längre än 20 tecken")]
    [Display(Name = "Organisationsnummer / Personnummer")]
    public string? OrgNumber { get; set; }

    
    [StringLength(100, ErrorMessage = "Adress får inte vara längre än 100 tecken")]
    [Display(Name = "Adress för utbildning")]
    public string? Address { get; set; }

    
    [EmailAddress(ErrorMessage = "Ogiltig e-postadress")]
    [StringLength(100, ErrorMessage = "E-postadress får inte vara längre än 100 tecken")]
    [Display(Name = "E-postadress")]
    public string? Email { get; set; }

    
    [Phone(ErrorMessage = "Ogiltigt telefonnummer")]
    [StringLength(20, ErrorMessage = "Telefonnummer får inte vara längre än 20 tecken")]
    [Display(Name = "Telefonnummer")]
    public string? PhoneNumber { get; set; }
}
