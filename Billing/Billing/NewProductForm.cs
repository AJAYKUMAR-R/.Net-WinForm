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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productname = textBoxproductName.Text;
            ProductRegex productRegex = new ProductRegex();


            if (productRegex.ProductName(productname))
            {
                NewProduct newProduct = new NewProduct();
                if (newProduct.AddNewProduct(productname, dateTimePickerbtnProductDate.Text))
                {
                    //Relod the Data Grid Again
                    DataTable data = newProduct.ShowData();
                    dataGridViewNewProduct.DataSource = data;
                    MessageBox.Show("Added Sucessfully");

                }
                else
                {
                    MessageBox.Show("Not Added");
                }
            }
            else
            {
                MessageBox.Show("At least 4 charcater or Incorrect Format");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cells = dataGridViewNewProduct.CurrentCell.RowIndex;
            if (dataGridViewNewProduct.Rows[cells].IsNewRow == false)
            {
                string productname = dataGridViewNewProduct.Rows[cells].Cells[1].Value.ToString();
                NewProduct newProduct = new NewProduct();
                bool check = newProduct.DeleteNew(productname);
                if (check)
                {
                    MessageBox.Show("Product has Been Delete");
                    //Relod the Data Grid Again
                    DataTable data = newProduct.ShowData();
                    dataGridViewNewProduct.DataSource = data;

                }
                else
                {
                    MessageBox.Show("Invalid  productname");
                }
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            DataTable data = newProduct.ShowData();
            dataGridViewNewProduct.DataSource = data;
        }
    }
}
