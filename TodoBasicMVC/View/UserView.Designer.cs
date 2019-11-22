namespace TodoBasicMVC.View
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.TodoBox = new System.Windows.Forms.TextBox();
            this.TodoLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TaskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelComplete = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TopPanel.Controls.Add(this.AddButton);
            this.TopPanel.Controls.Add(this.TodoBox);
            this.TopPanel.Controls.Add(this.TodoLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 63);
            this.TopPanel.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddButton.BackgroundImage = global::TodoBasicMVC.Properties.Resources.plusicon;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.Location = new System.Drawing.Point(751, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(37, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TodoBox
            // 
            this.TodoBox.AcceptsReturn = true;
            this.TodoBox.AcceptsTab = true;
            this.TodoBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TodoBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(160)))), ((int)(((byte)(212)))));
            this.TodoBox.Location = new System.Drawing.Point(506, 15);
            this.TodoBox.Name = "TodoBox";
            this.TodoBox.Size = new System.Drawing.Size(239, 37);
            this.TodoBox.TabIndex = 1;
            this.TodoBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TodoBox_KeyDown);
            // 
            // TodoLabel
            // 
            this.TodoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TodoLabel.AutoSize = true;
            this.TodoLabel.BackColor = System.Drawing.Color.Transparent;
            this.TodoLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoLabel.ForeColor = System.Drawing.Color.White;
            this.TodoLabel.Location = new System.Drawing.Point(12, 15);
            this.TodoLabel.Name = "TodoLabel";
            this.TodoLabel.Size = new System.Drawing.Size(181, 33);
            this.TodoLabel.TabIndex = 0;
            this.TodoLabel.Text = "TodoBasicMVC";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BottomPanel.Controls.Add(this.LabelComplete);
            this.BottomPanel.Controls.Add(this.LabelTotal);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Location = new System.Drawing.Point(0, 412);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 38);
            this.BottomPanel.TabIndex = 8;
            // 
            // LabelTotal
            // 
            this.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LabelTotal.Location = new System.Drawing.Point(12, 6);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(71, 23);
            this.LabelTotal.TabIndex = 2;
            this.LabelTotal.Text = "Tasks: 0";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearButton.Image = global::TodoBasicMVC.Properties.Resources.clearbutton2;
            this.ClearButton.Location = new System.Drawing.Point(341, 1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 38);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskPanel.AutoScroll = true;
            this.TaskPanel.Location = new System.Drawing.Point(0, 69);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(800, 346);
            this.TaskPanel.TabIndex = 7;
            // 
            // LabelComplete
            // 
            this.LabelComplete.AutoSize = true;
            this.LabelComplete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.LabelComplete.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LabelComplete.Location = new System.Drawing.Point(626, 7);
            this.LabelComplete.Name = "LabelComplete";
            this.LabelComplete.Size = new System.Drawing.Size(162, 23);
            this.LabelComplete.TabIndex = 3;
            this.LabelComplete.Text = "Tasks Completed: 0";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TaskPanel);
            this.Name = "UserView";
            this.Text = "TodoBasicMVC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserView_FormClosed);
            this.Load += new System.EventHandler(this.View_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TodoBox;
        private System.Windows.Forms.Label TodoLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.FlowLayoutPanel TaskPanel;
        private System.Windows.Forms.Label LabelComplete;
    }
}