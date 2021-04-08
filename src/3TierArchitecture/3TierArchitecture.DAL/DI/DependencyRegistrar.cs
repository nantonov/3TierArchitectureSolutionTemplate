using _3TierArchitecture.DAL.Interfaces.Repositories.Base;
using _3TierArchitecture.DAL.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3TierArchitecture.DAL.DI
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
