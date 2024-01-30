using Microsoft.AspNetCore.Identity;

namespace Seguridad.Identity.Models
{
    public class Usuario  :  IdentityUser
    {

        public string LastName { get; set; }
    }
}
