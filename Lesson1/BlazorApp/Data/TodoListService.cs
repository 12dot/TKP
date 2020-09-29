using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class TodoListService{
        public IList<TodoItem> todos = new List<TodoItem>();
        public string newTodo;
        public void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }
        }
        public void DeleteTodo(TodoItem todo)
        {
            todos.Remove(todo);
        }
    }

}

