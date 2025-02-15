using Microsoft.EntityFrameworkCore;

namespace mission6Assignment.Models
{
    public class movieFormContext : DbContext
    {
        public movieFormContext(DbContextOptions<movieFormContext> options) : base(options) // Constructor
        {

        }

        public DbSet<MovieForm> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<MovieForm>(entity =>
            {

                entity.ToTable("Movies");
                entity.HasKey(p => p.formID).HasName("PK_formID");

                entity.Property(p => p.formID)

                .HasColumnName("formID")

                .HasColumnType("int").ValueGeneratedNever();

                entity.Property(p => p.movieTitle)

                .HasColumnName("movieTitle");

            });

        }
    }
}
