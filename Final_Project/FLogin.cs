using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Eventing.Reader;

namespace Final_Project
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FLogin flogin = new FLogin();
            if (flogin.Result(panel1) == "Candidate")
            {
                this.Hide();
                FUser user = new FUser();
                user.ShowDialog();
            }
            else if(flogin.Result(panel1) == "Company")
            {
             
                this.Hide();
                FCompany company = new FCompany();
                company.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fSignUp = new FSignUp();
            fSignUp.ShowDialog();
        }

        public string Result(Panel p)
        {
            foreach (RadioButton i in p.Controls)
            {
                if (i.Checked)
                {
                    return i.Text.ToString();
                }
            }

            return "";
        }
        private void btnFogotPassword_Click(object sender, EventArgs e)
        {
                this.Hide();
                FFogotPassword ffogotPassword = new FFogotPassword();
                ffogotPassword.ShowDialog();
            
            
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
