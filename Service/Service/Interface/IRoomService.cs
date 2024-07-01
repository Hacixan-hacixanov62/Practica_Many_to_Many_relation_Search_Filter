using Service.DTOs.Admin.Rooms;

namespace Service.Service.Interface
{
    public interface IRoomService
    {
        Task CreateAsync(RoomCreateDto model);
        Task<IEnumerable<RoomDto>> GetAllWithAsync();
        Task<RoomDto> GetByIdAsync(int? id);
        Task DeleteAsync(int id);
        Task EditAsync(int id, RoomEditDto model);
        Task<IEnumerable<RoomDto>> GetByName(string name);
        Task<IEnumerable<RoomDto>> SortBySeatCount(string message);
        Task<IEnumerable<RoomDto>> SortByName(string message);
    }
}
