namespace abcCarTreders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(68, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 23);
            txtName.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(70, 97);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(323, 23);
            txtPass.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(317, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 327);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Vehicle Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPass;
        private Button button1;
    }
}
