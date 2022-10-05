﻿using DatingAPP.Data;
using DatingAPP.Interfaces;
using DatingAPP.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingAPP.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
