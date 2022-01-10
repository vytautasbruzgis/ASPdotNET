namespace _20220107_HotelCleaning.Models
{
    public class Visitor: Entity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
