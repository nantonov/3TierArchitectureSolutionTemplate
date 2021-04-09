using $safeprojectname$.Interfaces.Repositories.Base;
using $safeprojectname$.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$.DI
{
    public static class DependencyRegistrar
    {
        public static void AddDataAccessLevelServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });
        }
    }
}
