using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
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
            return GetAllNotDeleted().Where(x => x.HotelId == hotelId).ToList();
        }
    }
}
