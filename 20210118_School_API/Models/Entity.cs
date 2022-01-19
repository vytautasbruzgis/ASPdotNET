using System;

namespace _20210118_School_API.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

    }
}
