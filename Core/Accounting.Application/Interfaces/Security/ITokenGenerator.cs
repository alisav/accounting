using App.Domain.Entites;

namespace App.Application.Interfaces.Security
{
    public interface ITokenGenerator
    {
        string CreateToken(ApplicationUser user);
    }
}
