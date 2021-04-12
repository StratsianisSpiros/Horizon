using Entities.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<EmployeeEvent> Events { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
