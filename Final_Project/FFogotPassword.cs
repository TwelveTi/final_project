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
    public partial class FFogotPassword : Form
    {
        public FFogotPassword()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            FUpdatePassword f = new FUpdatePassword();
            f.ShowDialog();
        }
    }
}
