using FewZes.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FewZes.API.Data;

public class FewZesDbContext : DbContext
{
    public FewZesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Difficulty> Difficulties { get; set; }
    
    public DbSet<Region> Regions { get; set; }
    
    public DbSet<Walk> Walks { get; set; }
}