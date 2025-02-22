using Microsoft.EntityFrameworkCore;

namespace mission6Assignment.Models
{
    public class movieFormContext : DbContext
    {
        public movieFormContext(DbContextOptions<movieFormContext> options) : base(options) // Constructor
        {

        }

        public DbSet<MovieForm> Movies { get; set; }

    }
}
