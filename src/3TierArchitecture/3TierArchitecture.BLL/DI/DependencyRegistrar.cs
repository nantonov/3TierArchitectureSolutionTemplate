using _3TierArchitecture.DAL.DI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace _3TierArchitecture.BLL.DI
{
    public static class DependencyRegistrar
    {
        public static void AddBusinessLogicLayerServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDataAccessLevelServices(configuration);
        }
    }
}
