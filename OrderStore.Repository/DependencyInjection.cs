using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderStore.Domain.Intefaces;

namespace OrderStore.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ApplicationDbContext>(opt => opt
                  .UseMySql("server=localhost; port=3306; database=OrderStore; user=root; password=", ServerVersion.AutoDetect("server=localhost; port=3306; database=OrderStore; user=root; password=")));
            return services;
        }
    }
}
