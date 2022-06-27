using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Posts.Application.Mappings;
using System.Reflection;

namespace Posts.Application
{
    public static class ConfigureServices
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
