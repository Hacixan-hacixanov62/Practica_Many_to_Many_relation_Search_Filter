using Domain.Entities;

namespace Repository.Repositories.Interface
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        Task<IEnumerable<Room>> GetByName(string name);
        Task<IEnumerable<Room>> SortBySeatCount(string message);
        Task<IEnumerable<Room>> SortByName(string message);
    }
}
