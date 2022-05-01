
using CloudinaryDotNet;
using Lea.Common.Conventions;
using Lea.Data;
using Lea.Data.Configurations;
using Lea.Data.Entities.Identity;
using Lea.Services.AutoMapper;
using Lea.Services.Data.Models.Core;
using Lea.Web.Commands.Identity;
using Lea.Web.Handlers.Identity;
using Lea.Web.Responses.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Lea.Web.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddConventionalServices(this IServiceCollection services)
    {
        Type transientServiceInterface = typeof(ITransientService),
            scopedServiceInterface = typeof(IScopedService),
            singletonServiceInterface = typeof(ISingletonService);

        //TODO: add types from which to load services to this method
        var typesToRegister = GetInterfaceAndImplementationFromAssemblies();

        foreach (var type in typesToRegister)
        {
            if (transientServiceInterface.IsAssignableFrom(type.Interface))
            {
                services.AddTransient(type.Interface, type.Implementation);
            }
            else if (scopedServiceInterface.IsAssignableFrom(type.Interface))
            {
                services.AddScoped(type.Interface, type.Implementation);
            }
            else if (singletonServiceInterface.IsAssignableFrom(type.Interface))
            {
                services.AddSingleton(type.Interface, type.Implementation);
            }
        }

        return services;
    }

    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        => services.AddSingleton(
            AutoMapperMannager.RegisterMappings(
                typeof(LoginResponse).Assembly,
                typeof(LoginCommand).Assembly,
                typeof(StudentServiceModel).Assembly
            )
        );

    public static IServiceCollection AddCloudinary(this IServiceCollection services, IConfiguration configuration)
        => services.AddSingleton(new Cloudinary(
                new Account(
                    configuration["Cloudinary:CloudName"],
                    configuration["Cloudinary:ApiKey"],
                    configuration["Cloudinary:ApiSecret"]
                )
            ));

    public static IServiceCollection AddLeaDbContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<LeaDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

    public static IServiceCollection AddLeaIdentity(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            })
            .AddJwtBearer(options =>
            {
                var secret = Encoding.UTF8.GetBytes(configuration["JwtConfiguration:Secret"]);

                options.SaveToken = true;
                options.TokenValidationParameters = new()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secret),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true,
                };
            });

        services
            .AddIdentity<LeaUser, LeaRole>(IdentityOptionsProvider.IdentityOptions)
            .AddEntityFrameworkStores<LeaDbContext>();

        return services;
    }

    private static IEnumerable<Model> GetInterfaceAndImplementationFromAssemblies(params Type[] typesFromTheAssemblies)
    {
        IEnumerable<Model> result = new List<Model>();

        foreach (var type in typesFromTheAssemblies)
        {
            var publicTypesFromTheAssembly = type
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new Model
                {
                    Interface = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Interface != null);

            result = result.Concat(publicTypesFromTheAssembly);
        }

        return result;
    }
}

public class Model
{
    public Type Interface { get; set; }
    public Type Implementation { get; set; }
}