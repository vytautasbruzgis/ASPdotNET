using System;

namespace _20220118_School_API.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CompleteUntil { get; set; }
    }
}
