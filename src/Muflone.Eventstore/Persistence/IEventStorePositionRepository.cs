using System.Threading.Tasks;
using EventStore.ClientAPI;

namespace Muflone.Eventstore.Persistence
{
  public interface IEventStorePositionRepository
  {
    Task<Position> GetLastPosition();
    Task Save(long commitPosition, long preparePosition);
  }
}
