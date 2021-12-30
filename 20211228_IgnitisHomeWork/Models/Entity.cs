using System;

namespace _20211230_IgnitisHomeWork_V2.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
