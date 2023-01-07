using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class IdentityContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<IdentityUser> Users { get; set; }

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
