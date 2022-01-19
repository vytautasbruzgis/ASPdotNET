using System.Collections.Generic;

namespace _20210118_School_API.Models
{
    public class School : Entity
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; }
    }
}
