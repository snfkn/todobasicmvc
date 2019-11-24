using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoBasicMVC.Model;
using TodoBasicMVC.View;

namespace TodoBasicMVC.Controller
{
    public class UserController
    {
        private UserView _view;
        private TodoList _todolist = new TodoList();

        public UserController(UserView view)
        {
            this._view = view;
        }

        public void TodoListLoad()
        {
            _todolist.Load();
            foreach (Todo todo in _todolist)
            {
                _view.Add(todo);
            }
        }
        
        public void TodoAdd(string todoTask)
        {
            Todo newtodo = new Todo(todoTask);
            _todolist.Add(newtodo);
            _view.Add(newtodo);
        }
        public void TodoListSave()
        {
            _todolist.Save();
        }

        public void TodoDelete(Todo todo)
        {
            _todolist.Remove(todo);
            _view.Remove(todo);
        }

        public void TodoComplete(Todo todo)
        {
            _todolist.Remove(todo);
            _view.Complete(todo);
        }

        public void ClearAll()
        {
            _view.ClearAll();
            _todolist.Clear();
        }
    }
}
