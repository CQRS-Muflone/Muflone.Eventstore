using EventStore.ClientAPI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Muflone.Eventstore.Persistence;
using Muflone.Persistence;

namespace Muflone.Eventstore
{
  public static class EventStoreHelpers
  {
    public static IServiceCollection AddMufloneEventStore(this IServiceCollection services, string evenStoreConnectionString)
    {
      services.AddSingleton(provider =>
      {
        var connection = EventStoreConnection.Create(evenStoreConnectionString);
        connection.ConnectAsync();
        return connection;
      });
      services.AddScoped<IRepository, EventStoreRepository>();
      services.AddSingleton<IHostedService, EventDispatcher>();
      return services;
    }
  }
}