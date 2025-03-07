

using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<OfferEntity> Offers { get; set; }
    //public DbSet<AdminUserEntity> adminUsers { get; set; }
}
