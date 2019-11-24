using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBasicMVC.Model
{
    public class TodoList : List<Todo>
    {
        public void Load()
        {
            List<string> savedtodos = Properties.Settings.Default.SavedList;
            if (savedtodos != null)
            {
                foreach (string todotask in savedtodos)
                {
                    var todo = new Todo(todotask);
                    this.Add(todo);
                }
                Properties.Settings.Default.SavedList.Clear();
            }
            else
            {
                Properties.Settings.Default.SavedList = new List<string>();
            }
        }

        public void Save()
        {
            List<string> savedtodos = new List<string>();
            foreach (Todo todo in this)
            {
                savedtodos.Add(todo.TodoTask);
            }
            Properties.Settings.Default.SavedList = savedtodos;
            Properties.Settings.Default.Save();
        }

    }
}
