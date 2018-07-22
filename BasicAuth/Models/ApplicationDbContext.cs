using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicAuth.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=basicauth;uid=root;pwd=root;");
        // }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>(entity => {
                entity.Property(m => m.Email).HasMaxLength(127);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(127);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(127);
                entity.Property(m => m.UserName).HasMaxLength(127);
            });
            builder.Entity<IdentityRole>(entity => {
                entity.Property(m => m.Name).HasMaxLength(127); entity.Property(m => m.NormalizedName).HasMaxLength(127); 
            });
        }
    }
}