using System;

namespace _20211215_FirstEFApp.Models
{
    public class ToDoModel : NamedEntity
    {
        public string Description { get; set; }
        public DateTime ToDoUntil { get; set; }
        public CategoryModel Category { get; set; }
    }
}
