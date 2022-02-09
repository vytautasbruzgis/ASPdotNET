using System;
using System.ComponentModel.DataAnnotations;

namespace _20220209_School_API.Models
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
        public string Name { get; set; }
    }
}
