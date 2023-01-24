using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mOSP.Application.Contracts.Persistence;
using mOSP.Persistence.EF.Repositories;

namespace mOSP.Persistence.EF
{
    public static class PersistenceWithEFRegistration
    {
        public static IServiceCollection AddmOSPPersistenceEFServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<mOSPContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("mOSPConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IMedItemRepository, MedItemRepository>();
            services.AddScoped<IMedKitRepository, MedKitRepository>();
            services.AddScoped<IOspRepository, OspRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
