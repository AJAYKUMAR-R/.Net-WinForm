

namespace Billing
{
    public partial class Cregister : Form
    {
        

        public Cregister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user;
            string email;
            string mobile;
            string address;
            CoustomerRegex regex = new CoustomerRegex();

            if (!regex.Username(username.Text))
            {
                labeluserinvalid.Text = "invalid UserName";
                return;
            }
            else
            {
                labeluserinvalid.Text = "";
                user = username.Text;
            }

            if (!regex.UserMail(useremail.Text))
            {
                labelemailinvalid.Text = "InvalidMail";
                return;
            }
            else

            {
                labelemailinvalid.Text = "";
                email = useremail.Text;

            }

            if (!regex.Mobile(mobileno.Text))
            {
                labelinvalidmobile.Text = "Invalid Mobile";
                return;
            }
            else
            {
                labelinvalidmobile.Text = "";
                mobile = mobileno.Text;
            }

            if (!regex.Address(useraddress.Text))
            {
                labelinvalidadress.Text = "Invalid Address";
                return;
            }
            else
            {
                labelinvalidadress.Text = "";
                address = useraddress.Text;


            }

            CoustomerSignIn coustomerSign = new CoustomerSignIn();
            bool Rowaffected = coustomerSign.AddDataBase(user, email, mobile,address);
            if(Rowaffected == true)
            {
                MessageBox.Show("Saved !");
            }
            else
            {
                MessageBox.Show("Not Saved!");
            }


            /// <summary>
            /// CLear the Form
            /// </summary>

            username.Clear();
            useremail.Clear();
            mobileno.Clear();
            useraddress.Clear();
            this.Close();

        }
    }
}
