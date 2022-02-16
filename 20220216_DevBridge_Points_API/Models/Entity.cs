using System;

namespace _20220216_DevBridge_Points_API.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
    }
}
