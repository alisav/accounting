using Accounting.Application.Interfaces;
using Accounting.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            services.AddScoped<IAccountingDbContext>(provider => provider.GetService<AccountingDbContext>());

        }
    }
}
