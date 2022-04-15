using BLL.ServiceInterfaces;
using BLL.Services;
using DAL.Authorization.Repository;
using DAL.Authorization.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Diplom.ServiceExtensions
{
    public static class AddDependencyInjectionExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IAuthorizationServiceBll, AuthorizationService>();
            services.AddTransient<IAuthorizationRepository, AuthorizationRepository>();
        }
    }
}