using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class RoomRepository: RepositoryBase<Room>
    {
        public RoomRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public List<Room> GetRoomsByHotel(int hotelId)
        {
            return _dbSet.Where(x => x.HotelId == hotelId && x.IsDeleted == false).Include(x => x.Bookings).Include(y => y.Tasks).ToList();
        }
    }
}
