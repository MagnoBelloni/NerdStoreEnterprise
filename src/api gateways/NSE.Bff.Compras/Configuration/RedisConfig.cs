using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NSE.Bff.Compras.Configuration
{
    public static class RedisConfig
    {
        public static void AddRedis(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration =
                    configuration["Redis"];
                options.InstanceName = "NerStoreEnterprise-";
            });
        }
    }
}
