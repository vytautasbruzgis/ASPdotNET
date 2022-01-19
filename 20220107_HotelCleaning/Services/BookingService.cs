using _20220107_HotelCleaning.Models;
using _20220107_HotelCleaning.Repositories;
using System.Collections.Generic;

namespace _20220107_HotelCleaning.Services
{
    public class BookingService
    {
        private BookingRepository _bookingRepo;
        public BookingService (BookingRepository bookingRepository)
        {
            _bookingRepo = bookingRepository;
        }
        public void Create(Booking booking)
        {
            _bookingRepo.Add(booking);
        }
        public List<Booking> GetByRoom(int roomId)
        {
            return _bookingRepo.GetAll();
        }
        public void Update(Booking booking)
        {
            _bookingRepo.Update(booking);
        }
    }
}
