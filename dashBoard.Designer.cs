namespace abcCarTreders
{
    partial class dashBoard
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 28);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 28);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(266, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 20);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(180, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 20);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(815, 26);
            button1.Name = "button1";
            button1.Size = new Size(32, 26);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 102);
            button2.Name = "button2";
            button2.Size = new Size(251, 35);
            button2.TabIndex = 0;
            button2.Text = "Manage Car Details";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(12, 143);
            button3.Name = "button3";
            button3.Size = new Size(251, 35);
            button3.TabIndex = 1;
            button3.Text = "Manage Car Parts Details";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 184);
            button4.Name = "button4";
            button4.Size = new Size(251, 35);
            button4.TabIndex = 2;
            button4.Text = "Manage Customer Details";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(3, 225);
            button5.Name = "button5";
            button5.Size = new Size(251, 35);
            button5.TabIndex = 3;
            button5.Text = "Manage Customer Order Details";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(12, 266);
            button6.Name = "button6";
            button6.Size = new Size(251, 35);
            button6.TabIndex = 4;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = true;
            // 
            // dashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dash Board";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}