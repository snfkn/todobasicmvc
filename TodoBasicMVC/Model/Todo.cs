using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TodoBasicMVC.Model.TodoControls;

namespace TodoBasicMVC.Model
{
    public class Todo
    {
        public string TodoTask { get; set; }
        private Label _TodoLabel;
        public Label TodoLabel
        {
            get
            {
                if (_TodoLabel == null)
                {
                    _TodoLabel = new TodoLabel();
                }
                return _TodoLabel;
            }

            set
            {
                _TodoLabel = value;
            }
        }
        private Button _Tick;
        public Button Tick
        {
            get 
            {
                if (_Tick == null)
                {
                    _Tick = new Tick();
                }
                return _Tick;
            }
            set
            {
                _Tick = value;
            }
        }
        private Button _Cross;
        public Button Cross
        {
            get
            {
                if (_Cross == null)
                {
                    _Cross = new Cross();
                }
                return _Cross;
            }
            set
            {
                _Cross = value;
            }
        }
     
        public Todo(string task)
        {
            this.TodoLabel.Text = task;
        }

    }
}
