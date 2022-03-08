using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NEC_Demo_Auth.Auth
{
    public class ApplicationDbContextcs:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContextcs(DbContextOptions<ApplicationDbContextcs> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


    }
}
