using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seguridad.Identity.Models;

namespace Seguridad.Identity.DbContext
{
    public class AuthenticationContext : IdentityDbContext<Usuario>
    {

        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) :   base(options)
        {
        }
    }
}
