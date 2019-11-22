using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoBasicMVC.Model
{
    public class TodoList : List<Todo>
    {
        private int _TodosCompleted;

        public int TodosCompleted
        {
            get { return _TodosCompleted; }
            set { _TodosCompleted = value;  }
        }

    }
}
