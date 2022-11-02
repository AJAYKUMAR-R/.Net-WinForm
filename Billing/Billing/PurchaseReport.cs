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
    public partial class PurchaseReport : Form
    {
        Purchase purchaseReport = new Purchase();
        public PurchaseReport()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            
           
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
           
            panelPrice.Visible= true;
            panelDate.Visible = false;
          
           


        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {

            ProductRegex productRegex = new ProductRegex();

            if (productRegex.productPrice(textBoxPrice.Text))
            {
                DataTable data = purchaseReport.CoustomerRecordsPrice(Convert.ToDecimal(textBoxPrice.Text));
                dataGridViewPrice.DataSource = data;

            }
            else
            {

                MessageBox.Show("Price Not In Right Format");
                return;
            }

        }


        //Date button
        private void button2_Click(object sender, EventArgs e)
        {
            panelDate.Visible = true;
            panelPrice.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = purchaseReport.CoustomerRecords(dateTimePicker1.Text);
            dataGridView1.DataSource = dataTable;

        }


        

        
    }
}
