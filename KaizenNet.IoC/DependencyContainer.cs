using KaizenNet.Presenters;
using KaizenNet.RepositoryEFCore;
using KaizenNet.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KaizenNet.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddLatinoNetDependencies(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }

    }
}
