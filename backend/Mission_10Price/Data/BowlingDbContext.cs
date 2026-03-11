using Microsoft.EntityFrameworkCore;

namespace Mission_10Price.Data;

public class BowlingDbContext : DbContext
{
    public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Bowlers> Bowlers { get; set; }
    public DbSet<Teams> Teams { get; set; }
}