using Equinox.Infra.Data.Context;
using Equinox.UI.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace Equinox.UI.Web.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //UnComment this for first execution
            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<EquinoxContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<EventStoreSqlContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}