namespace abcCarTreders
{
    partial class signUp
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
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 412);
            panel1.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(12, 310);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Confirm Password";
            textBox7.Size = new Size(355, 29);
            textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(12, 275);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Password";
            textBox6.Size = new Size(355, 29);
            textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(12, 240);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(355, 29);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(12, 205);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Address Line 03";
            textBox4.Size = new Size(355, 29);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 170);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Address Line 02";
            textBox3.Size = new Size(355, 29);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 135);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Address Line 01";
            textBox2.Size = new Size(355, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 100);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Contact";
            textBox1.Size = new Size(355, 29);
            textBox1.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(12, 65);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(355, 29);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(12, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(355, 29);
            txtFirstName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 345);
            button1.Name = "button1";
            button1.Size = new Size(355, 43);
            button1.TabIndex = 17;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 411);
            Controls.Add(panel1);
            Name = "signUp";
            Text = "Sign Up";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button1;
    }
}