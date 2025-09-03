using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppTrainees.Models;

namespace WebAppTrainees.Models

{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Keep your existing Trainee model included in the identity DB
        public DbSet<Trainee> Trainnees { get; set; } = null!;
    }
}
