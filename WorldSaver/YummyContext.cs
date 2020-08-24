using Avengers.Models;
using Microsoft.EntityFrameworkCore;

namespace Avengers.WorldSaver
{
    public class YummyContext : DbContext
    {
        public DbSet<LstReview> LstReviews { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Service> Services { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LstReview>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Service>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Note>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
