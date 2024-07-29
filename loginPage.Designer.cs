namespace abcCarTreders
{
    partial class loginPage
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
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            linkLabel2 = new LinkLabel();
            btnLogin = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = Properties.Resources.Screenshot_2024_07_30_010506;
            label1.Location = new Point(1, 0);
            label1.MaximumSize = new Size(250, 300);
            label1.MinimumSize = new Size(590, 568);
            label1.Name = "label1";
            label1.Size = new Size(590, 568);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(634, 26);
            label2.Name = "label2";
            label2.Size = new Size(277, 50);
            label2.TabIndex = 1;
            label2.Text = "Welcome Back!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.MidnightBlue;
            linkLabel1.ForeColor = SystemColors.Control;
            linkLabel1.Location = new Point(821, 76);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(666, 76);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 3;
            label3.Text = "Don't Have an Account Yet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MidnightBlue;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(644, 189);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 4;
            label4.Text = "User Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MidnightBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(644, 269);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 5;
            label5.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(647, 229);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(264, 33);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(649, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(262, 33);
            txtPassword.TabIndex = 7;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.MidnightBlue;
            linkLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(794, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 17);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password ?";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(649, 383);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 51);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(583, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 553);
            panel1.TabIndex = 10;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 552);
            Controls.Add(btnLogin);
            Controls.Add(linkLabel2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private LinkLabel linkLabel2;
        private Button btnLogin;
        private Panel panel1;
    }
}