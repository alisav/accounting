using Accounting.Application.Interfaces;
using Accounting.Domain.Entites;
using Accounting.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Accounting.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AccountingDbContext>(opt =>
              opt.UseSqlServer(config.GetConnectionString("AccountingConnection"))
              .EnableSensitiveDataLogging()
              .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 4;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AccountingDbContext>();

            services.AddScoped<IAccountingDbContext>(provider => provider.GetService<AccountingDbContext>());

        }
    }
}
