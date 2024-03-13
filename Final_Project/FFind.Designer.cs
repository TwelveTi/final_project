namespace Final_Project
{
    partial class FFind
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
            vScrollBar1 = new VScrollBar();
            userControl11 = new UserControl1();
            userControl12 = new UserControl1();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1035, -2);
            vScrollBar1.Minimum = 1;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 677);
            vScrollBar1.TabIndex = 3;
            vScrollBar1.Value = 1;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.Window;
            userControl11.Label1Text = "Tên Công Việc";
            userControl11.Location = new Point(801, 84);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(220, 244);
            userControl11.TabIndex = 4;
            // 
            // userControl12
            // 
            userControl12.BackColor = SystemColors.Window;
            userControl12.Label1Text = "Tên Công Việc";
            userControl12.Location = new Point(801, 373);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(220, 244);
            userControl12.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(780, 32);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 6;
            label1.Text = "Danh Sach Cong Viec";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 246);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 7;
            label2.Text = "Ten Cong ty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 181);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 8;
            label3.Text = "Ten Cong Viec";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 308);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 9;
            label4.Text = "Ky Nang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 361);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 10;
            label5.Text = "Vi Tri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 404);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 11;
            label6.Text = "Thong tin cong Viec";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 354);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(214, 404);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 27);
            textBox5.TabIndex = 16;
            // 
            // FFind
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1059, 674);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userControl12);
            Controls.Add(userControl11);
            Controls.Add(vScrollBar1);
            Name = "FFind";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private VScrollBar vScrollBar1;
        public UserControl1 userControl11;
        public UserControl1 userControl12;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}