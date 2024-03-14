using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace School.Infrastructure
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<SchoolContext>(options =>
            {
                options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
            });

            return services;
        }
    }
}