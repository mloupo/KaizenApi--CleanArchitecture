using KaizenNet.UseCases.CreateProduct;
using KaizenNet.UseCases.GetAllProducts;
using KaizenNet.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace KaizenNet.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
            services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();
            return services;
        }
    }
}
