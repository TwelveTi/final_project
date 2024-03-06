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
    public partial class FCompany : Form
    {
        public FCompany()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FCompanyAddJob f = new FCompanyAddJob();
            f.ShowDialog();
        }

        private void btnApplied_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAppliedCompany f = new FAppliedCompany();
            f.ShowDialog();
        }
    }
}
