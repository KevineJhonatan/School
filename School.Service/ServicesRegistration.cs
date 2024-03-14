using Microsoft.Extensions.DependencyInjection;
using School.Core.Interfaces.Services;
using School.Service;

namespace School.Infrastructure
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddSchoolServices(this IServiceCollection services)
        {
            services.AddScoped<ISuperAdminService, SuperAdminService>();
            services.AddScoped<IJwtTokenService, JwtTokenService>();

            return services;
        }
    }
}