

namespace Infrastructure.Entities;

public class AdminUserEntity
{
    public int Id { get; set; }

   
    public string Email { get; set; } = null!;
    
    
    public string Password { get; set; } = null!;
}
