using Microsoft.EntityFrameworkCore;
using Virtual_intelligent_assistant.Models;

namespace Virtual_intelligent_assistant.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ViaProfile> ViaProfiles { get; set; }
        public DbSet<Prompt> Prompts { get; set; }
        public DbSet<ActionItem> Actions { get; set; }
        public DbSet<Appearance> Appearances { get; set; }
        public DbSet<ViaImage> ViaImages { get; set; }
        public DbSet<UserImage> UserImages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure proper relationships
            modelBuilder.Entity<ViaProfile>()
                .HasOne(v => v.Prompt)
                .WithOne(p => p.ViaProfile)
                .HasForeignKey<Prompt>(p => p.ViaProfileId);

            modelBuilder.Entity<ViaProfile>()
                .HasOne(v => v.Appearance)
                .WithOne(a => a.ViaProfile)
                .HasForeignKey<Appearance>(a => a.ViaProfileId);

            modelBuilder.Entity<ViaProfile>()
                .HasMany(v => v.Actions)
                .WithOne(a => a.ViaProfile)
                .HasForeignKey(a => a.ViaProfileId);
        }
    }
}
