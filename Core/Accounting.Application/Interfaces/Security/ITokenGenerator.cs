using Accounting.Domain.Entites;

namespace Accounting.Application.Interfaces.Security
{
    public interface ITokenGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}
