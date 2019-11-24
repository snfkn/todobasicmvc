using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    _TodoLabel = TodoLabelCreate();
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
                    _Tick = TickCreate();
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
                    _Cross = CrossCreate();
                }
                return _Cross;
            }
            set
            {
                _Tick = Cross;
            }
        }
        private Button TickCreate()
        {
            Button tick = new Button()
            {
                Font = new Font("Calibri", 12, FontStyle.Bold),
                Text = "✔",
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                ForeColor = Color.Green,
                Size = new Size(28, 28),
            };
            return tick;
        }

        private Button CrossCreate()
        {
            Button cross = new Button()
            {
                Font = new Font("Calibri", 12, FontStyle.Bold),
                Text = "✖",
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                ForeColor = Color.Red,
                Size = new Size(28, 28),
            };
            return cross;
        }

        private Label TodoLabelCreate()
        {
            Label todolabel = new Label()
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Top,
                TextAlign = System.Drawing.ContentAlignment.TopCenter,
                ForeColor = Color.CornflowerBlue,
                Size = new Size(500, 35),
                Font = new Font("Calibri", 16, FontStyle.Bold),
            };

            return todolabel;
        }
        public Todo(string task)
        {
            this.TodoLabel.Text = task;
            this.TodoTask = task;
        }

    }
}
