using Avengers.Models;
using Microsoft.EntityFrameworkCore;

namespace Avengers.WorldSaver
{
    public class YummyContext : DbContext
    {
        public DbSet<LstReview> LstReviews { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<RestaurantItem> RestaurantItems { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<ReviewItem> ReviewItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Video> Videos { get; set; }

        //public DbSet<Hashtag> Hashtags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"your_connection_string_here");
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

            modelBuilder.Entity<Options>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ReviewItem>()
                .Property(p => p.Id)
                .ValueGeneratedNever();
            modelBuilder.Entity<Picture>()
                .Property(p => p.Id)
                .ValueGeneratedNever();
            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .ValueGeneratedNever();
            modelBuilder.Entity<Video>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            //modelBuilder.Entity<Hashtag>()
            //    .Property(p => p.Id)
            //    .ValueGeneratedNever();
        }
    }
}
