using System;
using System.Windows.Forms;

namespace Billing
{
    public partial class UserRegister_Form : Form
    {
        public UserRegister_Form()
        {
            InitializeComponent();
        }

        private void textsingup_Click(object sender, EventArgs e)
        {
            
            string username;
            string email;
            string mobile;
            string password;

            RegexRegister regx = new RegexRegister();

            if (!regx.TextUser(textuser.Text))
            {
                labelinvalidUser.Text = "Invalid User";
                return;
            }
            else
            {
                labelinvalidUser.Text = "";
                username = textuser.Text;
            }
            if (!regx.TextPasssword(textpassword.Text))
            {
                labelinvalidpassword.Text = "Invalid Password";
                return;
            }
            else
            {
                labelinvalidpassword.Text = "";
                password = textpassword.Text;
            }

            if (!regx.Mobile(textmobile.Text))
            {
                labelinvalidmobile.Text = "Invalid Mobile";
                return;
            }
            else
            {
                labelinvalidmobile.Text = "";
                mobile = textmobile.Text;
            }

            string role = "";
            
            if(comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Please Select the ComboBox ");
                return;
            }    
            else
            {
                role = comboBoxRole.SelectedItem.ToString();
            }
                






            RegisterUser register = new RegisterUser();
            bool x = register.Registeruser(username,role, password, mobile);
            if (x)
            {
                MessageBox.Show("Saved !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            comboBoxRole.Refresh();
            textmobile.Clear();
            textpassword.Clear();
            textuser.Clear();

        }

        private void UserRegister_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
