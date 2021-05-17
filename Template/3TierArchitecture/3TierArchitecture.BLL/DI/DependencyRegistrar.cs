using $ext_safeprojectname$.DAL.DI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace $safeprojectname$.DI
{
    public static class DependencyRegistrar
    {
        public static void AddBusinessLogicLayerServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDataAccessLevelServices(configuration);
        }
    }
}
