using System;
using System.ComponentModel.DataAnnotations;

namespace _20210121_Shop_API.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }

    }
    public class NamedEntity : Entity
    {
        [MinLength(4)]
        public string Name { get; set; }
    }
}
