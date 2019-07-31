using LugNutzEnterprize.Models;
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
    }
}
