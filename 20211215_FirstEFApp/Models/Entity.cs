using System;

namespace _20211215_FirstEFApp.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
