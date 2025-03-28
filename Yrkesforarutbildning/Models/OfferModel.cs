using System.ComponentModel.DataAnnotations;

namespace Yrkesforarutbildning.Models;

public class OfferModel
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Vald tjänst")]
    public string? SelectedService { get; set; }

    [Required(ErrorMessage = "Du måste ange ett förnamn")]
    [StringLength(50, ErrorMessage = "Förnamn får inte vara längre än 50 tecken")]
    [Display(Name = "Förnamn")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Du måste ange ett efternamn")]
    [StringLength(50, ErrorMessage = "Efternamn får inte vara längre än 50 tecken")]
    [Display(Name = "Efternamn")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Du måste ange ett fullständigt personnummer/organisationsnummer")]
    [StringLength(20, ErrorMessage = "Organisationsnummer/Personnummer får inte vara längre än 20 tecken")]
    [Display(Name = "Organisationsnummer / Personnummer")]
    public string? OrgNumber { get; set; }

    [Required(ErrorMessage = "Du måste ange en fullständig adress")]
    [StringLength(100, ErrorMessage = "Adress får inte vara längre än 100 tecken")]
    [Display(Name = "Adress för utbildning")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Du måste ange ett datum")]
    [Display(Name = "Datum för utbildning")]
    public string? ChooseDate { get; set; }

    [Required(ErrorMessage = "Du måste ange en giligt e-post adress")]
    [EmailAddress(ErrorMessage = "Ogiltig e-postadress")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
    [StringLength(100, ErrorMessage = "E-postadress får inte vara längre än 100 tecken")]
    [Display(Name = "E-postadress")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Du måste ange ett giltigt telefonnummer")]
    [Phone(ErrorMessage = "Ogiltigt telefonnummer")]
    [StringLength(20, ErrorMessage = "Telefonnummer får inte vara längre än 20 tecken")]
    [Display(Name = "Telefonnummer")]
    public string? PhoneNumber { get; set; }
}
