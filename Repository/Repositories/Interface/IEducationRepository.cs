using Domain.Entities;

namespace Repository.Repositories.Interface
{
    public interface IEducationRepository : IBaseRepository<Education>
    {
        Task<IEnumerable<Education>> GetByName(string name);

        Task<IEnumerable<Education>> SortByName(string message);
    }
}
