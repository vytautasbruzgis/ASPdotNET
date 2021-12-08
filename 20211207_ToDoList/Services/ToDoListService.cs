using _20211207_ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using static System.Net.WebRequestMethods;

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
            //ToDo toDo1 = new ToDo() { Name = toDo.Name, Description};
            _toDoList.Add(toDo);
            System.IO.File.WriteAllText(_filePath, JsonSerializer.Serialize(_toDoList));
        }

        public void Remove(int id)
        {
            ToDo toDo = _toDoList.FirstOrDefault(x => x.Id == id);
            if(toDo != null)
            {
                _toDoList.Remove(toDo);
                System.IO.File.WriteAllText(_filePath, JsonSerializer.Serialize(_toDoList));
            }
            
        }

        public void ReadFileContents()
        {
            _toDoList = JsonSerializer.Deserialize <List<ToDo>>(System.IO.File.ReadAllText(_filePath));
            if (_toDoList.Any())
            {
                ToDo.IdCounter = _toDoList.Max(x => x.Id);
            }
        }
    }
}
