using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoBasicMVC.Model
{
    class TodoControls
    {
        public class Tick : Button
        {
            public Tick()
                : base()
            {
                this.Font = new Font("Calibri", 12, FontStyle.Bold);
                this.Text = "✔";
                this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.ForeColor = Color.Green;
                this.Size = new Size(28, 28);
            }
        }

        public class Cross : Button
        { 
            public Cross()
                : base()
            {
                this.Font = new Font("Calibri", 12, FontStyle.Bold);
                this.Text = "✖";
                this.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                this.ForeColor = Color.Red;
                this.Size = new Size(28, 28);
            }
        }

        public class TodoLabel : Label
        {
            public TodoLabel()
                : base()
            {
                this.AutoSize = false;
                this.Dock = DockStyle.Fill;
                this.Anchor = AnchorStyles.Top;
                this.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                this.ForeColor = Color.CornflowerBlue;
                this.Size = new Size(500, 35);
                this.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
        }
    }
}
