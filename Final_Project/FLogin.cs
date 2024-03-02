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
            this.Hide();
            FUser user=new FUser();
            user.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fSignUp = new FSignUp();
            fSignUp.ShowDialog();
        }

    }

}
