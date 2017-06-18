using EFCache;
using EFCache.Redis;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Core.Common;

namespace RedisCacheForPostgre.Entities
{
    public class Configuration : DbConfiguration
    {
        public Configuration()
        {
            var redisConnection = ConfigurationManager.ConnectionStrings["Redis"].ToString();
            var cache = new RedisCache(redisConnection);
            var transactionHandler = new CacheTransactionHandler(cache);
            AddInterceptor(transactionHandler);

            Loaded += (sender, args) =>
            {
                args.ReplaceService<DbProviderServices>(
                    (s, _) => new CachingProviderServices(s, transactionHandler, new RedisCachingPolicy())
                    );
            };
        }
    }
}
