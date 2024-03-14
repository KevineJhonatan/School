using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using School.Core.Settings;
using System.Text;

namespace School.API
{
    public static class ServicesRegistration
    {
        public static void AddSwaggerHandler(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "School API", Version = builder.Configuration["Version"] });
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Bearer Authentication with JWT Token",
                    Type = SecuritySchemeType.Http
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });
            });
        }

        public static void AddJWTTokenHandler(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                    ValidAudiences = builder.Configuration.GetSection("JwtSettings:Audiences").Get<List<string>>(),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true,
                    ValidAlgorithms = new[] { SecurityAlgorithms.HmacSha256 },
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SignInKey"]))
                };
            });
        }

        public static void AddAppSettings(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var jwtSetting = new JwtSetting
            {
                Issuer = builder.Configuration["JwtSettings:Issuer"],
                Audiences = builder.Configuration.GetSection("JwtSettings:Audiences").Get<List<string>>(),
                SignInKey = builder.Configuration["JwtSettings:SignInKey"]
            };

            services.AddSingleton(jwtSetting);
        }
    }
}
