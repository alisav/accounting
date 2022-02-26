using Accounting.Domain.Entites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<IdentityResult> CreateAsync(ApplicationUser user, string password);

        Task<IdentityResult> LoginAsync(ApplicationUser user, string password);
    }
}
