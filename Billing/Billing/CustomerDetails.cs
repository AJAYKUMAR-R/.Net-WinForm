
using System.Data;

namespace Billing
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            CoustomerSignIn coustomerSignIn = new CoustomerSignIn();
            DataTable data = coustomerSignIn.CoustomerRecords();
            dataGridView1.DataSource = data;
           
        }
    }
}
