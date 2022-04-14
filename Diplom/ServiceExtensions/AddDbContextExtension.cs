using DAL.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Diplom.ServiceExtensions
{
    public static class AddDbContextExtension
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.
              UseSqlServer(configuration.GetConnectionString("Diplom")));
        }
    }
}

