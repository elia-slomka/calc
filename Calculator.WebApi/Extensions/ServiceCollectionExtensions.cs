using Calculator.WebApi.Business;
using Calculator.WebApi.Business.Operations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Calculator.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = $"{Startup.ServiceName} API",
                    Version = "v1"
                });
                
                c.UseInlineDefinitionsForEnums();
            }).AddSwaggerGenNewtonsoftSupport();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                //I'd expect to have some kind of automatic registration, but for the sake of simplicity
                .AddTransient<IOperation, Addition>()
                .AddTransient<IOperation, Subtraction>()
                .AddTransient<IOperation, Multiplication>()
                .AddTransient<IOperation, Division>()
                .AddScoped<IOperationsFactory, OperationsFactory>()
                .AddScoped<ICalculator, Business.Calculator>();
        }
    }
}