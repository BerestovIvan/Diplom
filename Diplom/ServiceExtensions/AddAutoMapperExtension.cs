using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Diplom.Mapper;

namespace Diplom.ServiceExtensions
{
    public static class AddAutoMapperExtension
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AuthorizationMapper));
        }
    }
}
