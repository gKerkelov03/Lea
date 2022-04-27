
using Lea.Common.Conventions;

namespace Lea.Web.Infrastructure;

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

    public static IEnumerable<Model> GetInterfaceAndImplementationFromAssemblies(params Type[] typesFromTheAssemblies)
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