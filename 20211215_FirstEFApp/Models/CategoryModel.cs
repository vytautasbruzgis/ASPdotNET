using System.Collections.Generic;

namespace _20211215_FirstEFApp.Models
{
    public class CategoryModel : NamedEntity
    {
        public List<ToDoModel> ToDos { get; set; }
    }
}
