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
        public Label TodoLabel = new Label()
        {
            AutoSize = false,
            Dock = DockStyle.Fill,
            Anchor = AnchorStyles.Top,
            TextAlign = System.Drawing.ContentAlignment.TopCenter,
            ForeColor = Color.CornflowerBlue,
            Size = new Size(500, 35),
            Font = new Font("Calibri", 16, FontStyle.Bold),
        };
        public Button Tick = new Button()
        {
            Font = new Font("Calibri", 12, FontStyle.Bold),
            Text = "✔",
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            ForeColor = Color.Green,
            Size = new Size(28, 28),
        };

        public Button Cross = new Button()
        {
            Font = new Font("Calibri", 12, FontStyle.Bold),
            Text = "✖",
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            ForeColor = Color.Red,
            Size = new Size(28, 28),
        };

        public Todo(string task)
        {
            this.TodoLabel.Text = task;
        }

    }
}
