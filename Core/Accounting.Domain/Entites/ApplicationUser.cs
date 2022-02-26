using Microsoft.AspNetCore.Identity;

namespace Accounting.Domain.Entites
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
