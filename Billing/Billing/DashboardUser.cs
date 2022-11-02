using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing
{
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //billing
        private void button3_Click(object sender, EventArgs e)
        {
            billForm billForm = new billForm();
            billForm.ShowDialog();
        }

        private void coustomer_Click(object sender, EventArgs e)
        {
            Cregister cregister = new Cregister();
            cregister.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
