using _20220107_HotelCleaning.Data;
using _20220107_HotelCleaning.Models;
using System.Collections.Generic;
using System.Linq;

namespace _20220107_HotelCleaning.Repositories
{
    public class BookingRepository : RepositoryBase<Booking>
    {
        public BookingRepository(DataContext dataContext) : base(dataContext)
        {

        }
        public List<Booking> GetByRoom(int roomId)
        {
            /* reikėtų turbūt IQueryable metodą pasidaryti GetAllNotDeleted */
            return _dbSet.Where(x => x.RoomId == roomId && x.IsDeleted == false && x.IsCheckedOut == true || (x.IsCheckedOut == false && x.IsCheckedIn == false)).ToList();
        }
    }
}
