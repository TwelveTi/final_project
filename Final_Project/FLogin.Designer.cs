namespace Final_Project
{
    partial class FLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            btnFogotPassword = new Button();
            rbCompany = new RadioButton();
            rbCandidate = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 70);
            label1.Name = "label1";
            label1.Size = new Size(247, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome to ....";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 37);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 273);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 352);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(390, 352);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 27);
            textBox2.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(443, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(443, 485);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnFogotPassword
            // 
            btnFogotPassword.Location = new Point(411, 555);
            btnFogotPassword.Name = "btnFogotPassword";
            btnFogotPassword.Size = new Size(157, 29);
            btnFogotPassword.TabIndex = 8;
            btnFogotPassword.Text = "Fogot Password";
            btnFogotPassword.UseVisualStyleBackColor = true;
            btnFogotPassword.Click += btnFogotPassword_Click;
            // 
            // rbCompany
            // 
            rbCompany.AutoSize = true;
            rbCompany.Location = new Point(28, 25);
            rbCompany.Name = "rbCompany";
            rbCompany.Size = new Size(93, 24);
            rbCompany.TabIndex = 9;
            rbCompany.TabStop = true;
            rbCompany.Text = "Company";
            rbCompany.UseVisualStyleBackColor = true;
            // 
            // rbCandidate
            // 
            rbCandidate.AutoSize = true;
            rbCandidate.Location = new Point(220, 25);
            rbCandidate.Name = "rbCandidate";
            rbCandidate.Size = new Size(98, 24);
            rbCandidate.TabIndex = 10;
            rbCandidate.TabStop = true;
            rbCandidate.Text = "Candidate";
            rbCandidate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbCandidate);
            panel1.Controls.Add(rbCompany);
            panel1.Location = new Point(318, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 75);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1028, 680);
            Controls.Add(btnFogotPassword);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Button btnSignUp;
        private Button btnFogotPassword;
        public RadioButton rbCompany;
        public RadioButton rbCandidate;
        public Panel panel1;
    }
}
