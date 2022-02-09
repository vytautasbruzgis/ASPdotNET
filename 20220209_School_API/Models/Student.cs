using _20220209_School_API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220209_School_API.Models
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
