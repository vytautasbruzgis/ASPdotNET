using System.Collections.Generic;

namespace _20220107_HotelCleaning.Models
{
    public class Visitor: Entity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public List<Booking> Bookings { get; set; }
        public string FullName { get
            {
                return this.Person == null ? "" : this.Person.FullName;
            }
        }
    }
}
