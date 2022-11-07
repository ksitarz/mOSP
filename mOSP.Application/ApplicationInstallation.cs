using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace mOSP.Application
{
    public static class ApplicationInstallation
    {
        public static IServiceCollection AddmOSPApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
