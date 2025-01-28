using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductInventory.Domain.Interfaces;
using ProductInventory.Domain.Repositories;

namespace ProductInventory.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainDependencies( this IServiceCollection services)
        {
            services.AddDbContext<ProductDbContext>( options =>
            {
                options.UseInMemoryDatabase("ProductDB");
            });
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IVariantRepository, VariantRepository>();
            services.AddScoped<ISubVariantRepository, SubVariantRepository>();
            return services;
        }
    }
}