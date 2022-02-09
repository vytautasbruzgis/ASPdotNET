using _20220209_School_API.Models;
using System.Collections.Generic;

namespace _20220209_School_API.Models
{
    public class School : NamedEntity
    {
        public List<Student> Students;
    }
}
