﻿using LugNutzEnterprize.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LugNutzEnterprize.Data
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
    }
}