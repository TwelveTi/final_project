using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FFind : Form
    {
        public FFind()
        {
            InitializeComponent();
            //UserControl1 userControl = new UserControl1();
            // Thêm User Control vào form
            // this.Controls.Add(userControl);
            // userControl.Dock = DockStyle.Fill;

            // Gọi phương thức OnClick khi click vào User Control
            userControl11.Click += (sender, e) =>
            {
                //userControl11.OnClick();

                userControl11.Label1Text = "Cong Ty A";
                add(userControl11);
            };
            userControl12.Click += (sender, e) =>
            {
                // userControl12.OnClick();
                userControl12.Label1Text = "Cong Ty B";
                add(userControl12);
            };
        }

        public void add(UserControl1 us)
        {
            textBox1.Text=us.label1.Text;
            textBox2.Text=us.label2.Text;
            textBox3.Text=us.label3.Text;
            textBox4.Text=us.label4.Text;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

       





        //  private void button1_Click(object sender, EventArgs e)
        //{
        //  // Tạo một công việc mới.
        //Job job = new Job();
        //    job.Title = "Công việc mới";
        //    job.Company = "Công ty mới";
        //    job.Location = "Vị trí mới";
        //    job.Skills = "Kỹ năng mới";

        // Tạo khối mới cho công việc mới.
        //  Panel panel = CreateJobPanel(job);

        // Thêm khối mới vào form.
        //    this.Controls.Add(panel);

        // Tự động bố cục lại form.
        //    this.PerformLayout();
        //}
        //private Panel CreateJobPanel(Job job)
        //{
        // Tạo panel mới.
        //  Panel panel = new Panel();
        //  panel.Dock = DockStyle.Top;

        // Thêm các control vào panel.
        //  Label labelTitle = new Label();
        //  labelTitle.Text = job.Title;
        //  labelTitle.Dock = DockStyle.Top;
        //  panel.Controls.Add(labelTitle);

        //  Label labelCompany = new Label();
        //  labelCompany.Text = job.Company;
        //  labelCompany.Dock = DockStyle.Top;
        //  panel.Controls.Add(labelCompany);

        // ...

        //    return panel;
        //}
    }
}
