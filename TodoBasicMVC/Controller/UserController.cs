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
            /*List<string> savedtodos = Properties.Settings.Default.SavedList;
            if (savedtodos != null)
            {
                foreach (string todotask in savedtodos)
                {
                    var todo = new Todo(todotask);
                    _todolist.Add(todo);
                    _view.Add(todo);
                }
                Properties.Settings.Default.SavedList.Clear();
            }
            else 
            {
                Properties.Settings.Default.SavedList = new List<string>();
            }           */
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
            /*            List<string> savedtodos = Properties.Settings.Default.SavedList;
                        foreach (Todo todo in _todolist)
                        {
                            savedtodos.Add(todo.TodoLabel.Text);
                        }
                        Properties.Settings.Default.SavedList = savedtodos;
                        Properties.Settings.Default.Save();*/
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
