using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Room>> GetByName(string name)
        {
            var data = await _context.Rooms.Where(m => m.Name.Trim().Contains(name.Trim())).ToListAsync();
            return data;
        }

        public async  Task<IEnumerable<Room>> SortByName(string message)
        {
            if (message == "asc")
            {
                var data = await _context.Rooms.OrderBy(m => m.Name).ToListAsync();
                return data;
            }
            else
            {
                var data = await _context.Rooms.OrderByDescending(m => m.Name).ToListAsync();

                return data;
            }
        }

        public async Task<IEnumerable<Room>> SortBySeatCount(string message)
        {
            if (message == "asc")
            {
                var data = await _context.Rooms.OrderBy(m => m.SeatCount).ToListAsync();
                return data;
            }
            else
            {
                var data = await _context.Rooms.OrderByDescending(m => m.SeatCount).ToListAsync();

                return data;
            }
        }
    }
}
