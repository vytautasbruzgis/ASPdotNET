using System.ComponentModel.DataAnnotations.Schema;

namespace _20220107_HotelCleaning.Models
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
