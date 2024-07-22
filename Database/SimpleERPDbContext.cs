using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleERP.Models.Account;

namespace SimpleERP.Database
{
    public class SimpleERPDbContext : IdentityDbContext<ApplicationUser>
    {
        public SimpleERPDbContext(DbContextOptions<SimpleERPDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        
    }
}
