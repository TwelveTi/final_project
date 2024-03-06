namespace Final_Project
{
    partial class FCompany
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
            dataGridView1 = new DataGridView();
            btnAddJob = new Button();
            btnupdate = new Button();
            btnDelete = new Button();
            btnNone = new Button();
            btnApplied = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1142, 443);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddJob
            // 
            btnAddJob.Location = new Point(46, 542);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(139, 50);
            btnAddJob.TabIndex = 1;
            btnAddJob.Text = "ADD JOB";
            btnAddJob.UseVisualStyleBackColor = true;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(484, 542);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(141, 52);
            btnupdate.TabIndex = 2;
            btnupdate.Text = "UPDATE JOB";
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(908, 542);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE JOB";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNone
            // 
            btnNone.Location = new Point(527, 22);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(107, 40);
            btnNone.TabIndex = 4;
            btnNone.Text = "None";
            btnNone.UseVisualStyleBackColor = true;
            // 
            // btnApplied
            // 
            btnApplied.Location = new Point(952, 22);
            btnApplied.Name = "btnApplied";
            btnApplied.Size = new Size(124, 40);
            btnApplied.TabIndex = 5;
            btnApplied.Text = "Applied";
            btnApplied.UseVisualStyleBackColor = true;
            btnApplied.Click += btnApplied_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(87, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 38);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FCompany
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1193, 645);
            Controls.Add(btnBack);
            Controls.Add(btnApplied);
            Controls.Add(btnNone);
            Controls.Add(btnDelete);
            Controls.Add(btnupdate);
            Controls.Add(btnAddJob);
            Controls.Add(dataGridView1);
            Name = "FCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddJob;
        private Button btnupdate;
        private Button btnDelete;
        private Button btnNone;
        private Button btnApplied;
        private Button btnBack;
    }
}