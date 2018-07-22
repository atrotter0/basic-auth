using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasicAuth.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=basicauth;uid=root;pwd=root;");
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}