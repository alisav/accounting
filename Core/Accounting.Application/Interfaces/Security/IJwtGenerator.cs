using Accounting.Domain.Entites;

namespace Accounting.Application.Interfaces.Security
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}
