namespace Final_Project
{
    partial class UserControl1
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

        public void OnClick()
        {
            // Xử lý sự kiện click
            MessageBox.Show("User Control đã được click!");
            
        }
        public string Label1Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 0;
            label1.Text = "Tên Công Việc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 83);
            label2.Name = "label2";
            label2.Size = new Size(152, 35);
            label2.TabIndex = 1;
            label2.Text = "Tên Công Ty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 133);
            label3.Name = "label3";
            label3.Size = new Size(107, 35);
            label3.TabIndex = 2;
            label3.Text = "Kỹ Năng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 179);
            label4.Name = "label4";
            label4.Size = new Size(71, 35);
            label4.TabIndex = 3;
            label4.Text = "Vị Trí";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(219, 253);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
    }
}
