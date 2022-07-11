namespace Muflone.Eventstore.Persistence
{
  public interface IEventStorePositionRepository
  {
    Task<IEventStorePosition> GetLastPosition();
    Task Save(IEventStorePosition position);
  }
}