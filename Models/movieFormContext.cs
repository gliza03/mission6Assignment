using Microsoft.EntityFrameworkCore;

namespace mission6Assignment.Models
{
    public class movieFormContext : DbContext
    {
        public movieFormContext(DbContextOptions<movieFormContext> options) : base(options) // Constructor
        {

        }

        public DbSet<MovieForm> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId=1, CategoryName = "Horror" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Comedy" },
                new Category { CategoryId = 4, CategoryName = "Romance" }

               );
        }

    }
}
