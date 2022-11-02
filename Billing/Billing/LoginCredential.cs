using System;
using System.Windows.Forms;

namespace Billing
{
    public partial class LoginCredential : Form
    {
        public LoginCredential()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            textuserpassword.UseSystemPasswordChar = true;
            string username = textusername.Text;
            string userpassword = textuserpassword.Text;

            Login login = new Login();
            string value = login.LoginUser(username, userpassword);

            if (value == "user")
            {
                this.Hide();
                DashboardUser dashboardUser = new DashboardUser();
                dashboardUser.ShowDialog();
                




            }else if(value == "admin")
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                

            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }

            
        }

        private void LoginCredential_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_MouseHover(object sender, EventArgs e)
        {
            btnregister.BackColor = Color.FromArgb(51,204, 204);
        }

        private void btnregister_MouseLeave(object sender, EventArgs e)
        {
            btnregister.BackColor = Color.Transparent;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            UserRegister_Form userRegister_Form = new UserRegister_Form();
            userRegister_Form.Show();
        }

        private void textuserpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
