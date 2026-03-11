using Microsoft.EntityFrameworkCore;
namespace Mission_10Price.Models;

//Database that inherits from the DbContext class
public class BowlingDbContext : DbContext
{
    //builds the database context, options is the connection to the database
    public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
    {
        
    }
    //DbSet is a collection of objects that are stored in the database
    public DbSet<Bowlers> Bowlers { get; set; }
    public DbSet<Teams> Teams { get; set; }
}