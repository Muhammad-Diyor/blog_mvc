using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCPortfolio.Entities;

namespace MVCPortfolio.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
     public DbSet<Post>? Posts { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}