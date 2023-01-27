using Data.Mongo.Repo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Data.Mongo;
public static class ServiceExtensions
{
    public static void AddMongo(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbOptions>(configuration.GetSection("MongoDbSettings"));
        services.AddSingleton<MongoDbOptions>(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<MongoDbOptions>>().Value);

        services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
    }
}
