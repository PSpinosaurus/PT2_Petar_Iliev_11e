using Microsoft.EntityFrameworkCore;
using System;
using BusinessLayer;


namespace DataLayer
{
    public class Test2DbContext : DbContext
    {
        public Test2DbContext()
        {
            
        }

        public Test2DbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-40HMVT5;Database=Test2Db;Trusted_Connection=True;TrustServerCertificate=Yes;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SetFriends>().HasKey(x => new { x.FriendId, x.SubFriendId });
            modelBuilder.Entity<User>()
            .HasMany(e => e.Friends)
            .WithMany(e => e.FriendOf)
            .UsingEntity<SetFriends>(
                e => e.HasOne<User>().WithMany().HasForeignKey(e => e.FriendId),
                e => e.HasOne<User>().WithMany().HasForeignKey(e => e.SubFriendId));

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
