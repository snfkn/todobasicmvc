using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoBasicMVC.Controller;
using TodoBasicMVC.Model;

namespace TodoBasicMVC.View
{
    public partial class UserView : Form
    {
        private UserController _controller;

        private int _TodoTotal;
        public int TodoTotal
        {
            get
            {
                if (_TodoTotal < 0)
                {
                    _TodoTotal = 0;
                }
                return _TodoTotal;
            }

            set
            {
                _TodoTotal = value;
                LabelTotal.Text = $"Tasks: {_TodoTotal}";
            }
        }
        private int _TodoCompleted;
        public int TodoCompleted
        {
            get
            {
                return _TodoCompleted;
            }

            set
            {
                _TodoCompleted = value;
                LabelComplete.Text = $"Tasks Complete: {_TodoCompleted}";
            }
        }

        private void TodoTotalTicker(int number)
        {
            TodoTotal += number;
        }

        private void TodoCompletedTicker(int number)
        {
            TodoCompleted += number;
        }

        public void ControllerSet(UserController controller)
        {
            _controller = controller;
        }
        public UserView()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
        }

        public void Add(Todo todo)
        {
            todo = ButtonSetup(todo);
            TaskPanel.Controls.Add(todo.TodoLabel);
            TaskPanel.Controls.Add(todo.Tick);
            TaskPanel.Controls.Add(todo.Cross);
            TaskPanel.SetFlowBreak(todo.Cross, true);
            TodoTotalTicker(1);
        }
        public void Remove(Todo todo)
        {
            TaskPanel.Controls.Remove(todo.TodoLabel);
            TaskPanel.Controls.Remove(todo.Tick);
            TaskPanel.Controls.Remove(todo.Cross);
            TodoTotalTicker(-1);
        }

        public void Complete(Todo todo)
        {
            Remove(todo);
            TodoCompletedTicker(1);
        }

        private void TotalCompleteClear()
        {
            TodoTotal = 0;
            TodoCompleted = 0;
        }
        public void ClearAll()
        {
            TaskPanel.Controls.Clear();
            TotalCompleteClear();
        }

        public Todo ButtonSetup(Todo todo)
        {
            todo.Cross.Click += delegate
            {
                _controller.TodoDelete(todo);
            };

            todo.Tick.Click += delegate
            {
                _controller.TodoComplete(todo);
            };

            return todo;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _controller.TodoAdd(TodoBox.Text);
            TodoBox.Text = string.Empty;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _controller.ClearAll();
        }

        private void TodoBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton.PerformClick();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void UserView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.TodoListSave();
        }
    }
}
