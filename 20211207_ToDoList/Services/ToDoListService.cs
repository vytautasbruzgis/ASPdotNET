using _20211207_ToDoList.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace _20211207_ToDoList.Services
{
    public class ToDoListService
    {
        private string _filePath = "c:/tmp/ToDoList.txt";
        List<ToDo> _toDoList = new List<ToDo>();

        public ToDoListService()
        {
            ReadFileContents();
        }
        public List<ToDo> GetAll()
        {
            return _toDoList;
        }

        public void Add(ToDo toDo)
        {
            _toDoList.Add(toDo);
            System.IO.File.AppendAllText(_filePath, JsonSerializer.Serialize(toDo) + "\r\n");
        }

        public void ReadFileContents()
        {
            foreach (string line in System.IO.File.ReadLines(_filePath))
            {
                if (!line.Equals(""))
                {
                    ToDo toDo = JsonSerializer.Deserialize<ToDo>(line);
                    _toDoList.Add(toDo);
                }
            }
        }
    }
}
