using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TodoBasicMVC.View.UserView;
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
            List<string> savedtodos = Properties.Settings.Default.SavedList;
            if (savedtodos != null)
            {
                foreach (string todotask in savedtodos)
                {
                    var todo = new Todo(todotask);
                    _todolist.Add(todo);
                    _view.Add(todo);
                }
                this.UpdateLabels();
                Properties.Settings.Default.SavedList.Clear();
            }
            else 
            {
                Properties.Settings.Default.SavedList = new List<string>();
            }           
        }
        
        private void UpdateLabels()
        {
            _view.LabelUpdate(_todolist.Count, _todolist.TodosCompleted);
        }
        public void TodoAdd(string todoTask)
        {
            Todo newtodo = new Todo(todoTask);
            _todolist.Add(newtodo);
            _view.Add(newtodo);
            this.UpdateLabels();
        }
        public void TodoListSave()
        {
            List<string> savedtodos = Properties.Settings.Default.SavedList;
            foreach (Todo todo in _todolist)
            {
                savedtodos.Add(todo.TodoLabel.Text);
            }
            Properties.Settings.Default.SavedList = savedtodos;
            Properties.Settings.Default.Save();
        }

        public void TodoDelete(Todo todo)
        {
            _todolist.Remove(todo);
            _view.Remove(todo);
            this.UpdateLabels();
        }

        public void TodoComplete(Todo todo)
        {
            TodoDelete(todo);
            _todolist.TodosCompleted++;
            this.UpdateLabels();
        }

        public void ClearAll()
        {
            _view.ClearAll();
            _todolist.Clear();
            _todolist.TodosCompleted = 0;
            _view.LabelUpdate(0,0);
        }
    }
}
