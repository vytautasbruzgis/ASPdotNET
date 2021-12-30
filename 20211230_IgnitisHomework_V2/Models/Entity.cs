using System;

namespace _20211230_IgnitisHomework_V2.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class NamedEntity : Entity
    {
        public string Name { get; set; }
    }
}
