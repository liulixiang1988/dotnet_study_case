using System.Reflection;
using api_demo.Workers;

namespace api_demo.Extensions;

public static class WorkerExtensions
{
    public static IServiceCollection AddKeyedSingletonFromTypeName(this IServiceCollection services, string fullClassName, string key)
    {
        
        // Get the Type from the class name
        var type = Type.GetType(fullClassName);

        // Check if the type is not null and it implements IUnifyModelRunner
        if (type != null && typeof(IWorker).IsAssignableFrom(type))
        {
            // var methods = typeof(ServiceCollectionServiceExtensions).GetMethods();
            // // print all methods, including parameters
            // foreach (var method in methods)
            // {
            //     if (method.Name != "AddKeyedSingleton") continue;
            //     //if (!method.IsGenericMethod) continue;
            //     Console.WriteLine("---"+method.Name);
            //     Console.WriteLine("IS GENERIC: " + method.IsGenericMethod);
            //     foreach (var parameter in method.GetParameters())
            //     {
            //         Console.WriteLine($"  {parameter.ParameterType} {parameter.Name}");
            //     }
            //
            //     var g = method.GetGenericArguments();
            //     foreach (var gg in g)
            //     {
            //         Console.WriteLine($"gg:  {gg}");
            //     }
            //
            //     try
            //     {
            //         var generic2 = method.MakeGenericMethod(typeof(IWorker), type);
            //         generic2.Invoke(null, new object[] { services, key });
            //         Console.WriteLine("*******************************************Invoked");
            //     } catch (Exception e)
            //     {
            //         Console.WriteLine("exception88888");
            //     }
            //     
            // }
            // Use reflection to call the generic method AddKeyedSingleton
            var method2 = typeof(ServiceCollectionServiceExtensions).GetMethod(nameof(ServiceCollectionServiceExtensions.AddKeyedSingleton), 2,
                new Type[] { typeof(IServiceCollection), typeof(object)  });
            var generic = method2.MakeGenericMethod(typeof(IWorker), type);
            generic.Invoke(null, new object[] { services, key });
        }
        return services;
    }
    
    public static IServiceCollection LoadWorkers(this IServiceCollection services, string nameSpace)
    {
        var classNames = GetClassNamesInNamespace(nameSpace);
        foreach (var className in classNames)
        {
            services.AddKeyedSingletonFromTypeName($"{nameSpace}.{className}", className);
        }
        return services;
    }

    
    public static List<string> GetClassNamesInNamespace(string nameSpace)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var types = assembly.GetTypes()
            .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
            .Where(t => t is { IsClass: true, IsAbstract: false })
            //.Where(t=> t.GetInterfaces().Contains(typeof(IWorker)))
            .ToList();

        var classNames = new List<string>();
        foreach (var type in types)
        {
            classNames.Add(type.Name);
        }

        return classNames;
    }
}