using System;
using System.ComponentModel.DataAnnotations;

namespace _20211207_ToDoList.Models
{
    public class ToDo
    {
        [Required(ErrorMessage = "Title is required")]
        public string Name { get; set; }
        
        public string Description { get; set; }
        public int Id { get; set; }

        public static int IdCounter = 0;
    }
}
