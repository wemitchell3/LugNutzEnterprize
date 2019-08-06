using LugNutzPremium.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LugNutzPremium.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.SetCommandTimeout(int.MaxValue);
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<MaintenanceTask> MaintenanceTask { get; set; }

        public DbSet<Message> Message { get; set; }

        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<WishList> WishList { get; set; }

        public DbSet<Topic> Topic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MaintenanceTask>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<WishList>()
               .Property(b => b.CreatedDate)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Vehicle>()
               .Property(b => b.CreatedDate)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Message>()
               .Property(b => b.CreatedDate)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Topic>()
               .Property(b => b.CreatedDate)
               .HasDefaultValueSql("GETDATE()");

            ApplicationUser user= new ApplicationUser
            {
                FirstName = "Chris",
                LastName = "Morgan",
                StreetAddress = "123 Infinity Way",
                UserName = "chris@chris.com",
                NormalizedUserName = "CHRIS@CHRIS.COM",
                Email = "chris@chris.com",
                NormalizedEmail = "CHRIS@CHRIS.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "12345678-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser user5 = new ApplicationUser
            {
                FirstName = "Billy",
                LastName = "M",
                StreetAddress = "33 Lover's Lane",
                UserName = "billy@billy.com",
                NormalizedUserName = "BILLY@BILLY.COM",
                Email = "billy@billy.com",
                NormalizedEmail = "BILLY@BILLY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f004300-a4d9-48e9-9ebb-8803db794577",
                Id = "45670330-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHashBilly = new PasswordHasher<ApplicationUser>();
            user5.PasswordHash = passwordHashBilly.HashPassword(user, "Billy8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user5);

            modelBuilder.Entity<Vehicle>().HasData(
               new Vehicle()
               {
                   VehicleId = 1,
                   UserId = user.Id,
                   ModelYear = "2019",
                   Make = "Cadillac",
                   Model = "XT4"
               }
           );
        }
    }
}
