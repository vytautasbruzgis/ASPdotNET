namespace _20210118_School_API.Models
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }

    }
}
