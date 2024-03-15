using Microsoft.EntityFrameworkCore;

namespace Mission10.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        public DbSet <Bowler> Bowlers { get; set; }
        public DbSet <Team> Teams { get; set; }
    }
}
