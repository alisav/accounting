﻿using Accounting.Application.Interfaces.Security;
using Accounting.JwtSecurity.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Accounting.JwtSecurity
{
    public static class ServiceRegistration
    {
        public static void AddJwtSecurityRegistration(this IServiceCollection services, IConfiguration config)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateAudience = false,
                        ValidateIssuer = false,
                    };
                });

            services.AddScoped<IJwtGenerator, JwtGenerator>();
        }
    }
}
