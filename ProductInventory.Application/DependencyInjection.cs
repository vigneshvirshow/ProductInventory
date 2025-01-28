using Microsoft.Extensions.DependencyInjection;
using ProductInventory.Application.Interfaces;
using ProductInventory.Application.Services;

namespace ProductInventory.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IVariantService, VariantService>();
            services.AddScoped<ISubVariantService, SubVariantService>();
            return services;
        }   
    }
}
