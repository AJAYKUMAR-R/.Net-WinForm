
using System.Data;


namespace Billing
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            DataTable data = updateProduct.ShowData();
            datagridUpdate.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            string productcateid = "";
            //Exception For Invalid ProductID
            try
            {
                productcateid = textBoxProductName.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Invalid  ProductId ");
                return;
            }
            List<string> list = updateProduct.ProductSearch(productcateid);
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Product Not Found");
            }
            else
            {
                textBoxProductName.Text = list[0];
                textBoxProductStock.Text = list[1];
                textBoxProductPrice.Text = list[2];

            }
            
             
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = "";
            string description = "";
            int stocks = 0;
            decimal price = 0;

            //Exception For Invalid ProductID
            ProductRegex regex = new ProductRegex();
            if (!regex.ProductName(textBoxProductName.Text))
            {
                labelInvalidproductName.Text = "Invalid ProductName";
                return;
            }
            else
            {
                labelInvalidproductName.Text = "";
                name = textBoxProductName.Text;
            }

            if (!regex.productStockCount(textBoxProductStock.Text) || textBoxProductStock.Text == "0")
            {
                labelinvalidProductStock.Text = "Invalid Product Count";
                return;
            }
            else
            {
                labelinvalidProductStock.Text = "";
                stocks = Convert.ToInt32(textBoxProductStock.Text);
            }

            if (!regex.productPrice(textBoxProductPrice.Text))
            {
                labelinvalidProductprice.Text = "Invalid Price Count";
                return;
            }
            else
            {
                labelinvalidProductprice.Text = "";
                price = Convert.ToDecimal(textBoxProductPrice.Text);
            }



            UpdateProduct updateProduct = new UpdateProduct();

            bool check = updateProduct.UpdateProductDetails(name, stocks, price);
            if (check)
            {
                MessageBox.Show("Product Update");
                textBoxProductName.Clear();
                textBoxProductPrice.Clear();
                textBoxProductStock.Clear();
            }
            else
            {
                MessageBox.Show("Product Not Updated Or ProductId Incorrect");
            }


        
           


            //Relod the Data Grid Again
            UpdateProduct update = new UpdateProduct();
            DataTable data = update.ShowData();
            datagridUpdate.DataSource = data;

        }

      

        private void datagridUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int cells = datagridUpdate.CurrentCell.RowIndex;
            if (datagridUpdate.Rows[cells].IsNewRow == false)
            {
                string productname = datagridUpdate.Rows[cells].Cells[2].Value.ToString();
                UpdateProduct updateProduct = new UpdateProduct();
                bool check = updateProduct.DeleteProductDetails(productname);
                if (check)
                {
                    MessageBox.Show("Product has Been Delete");
                    //Relod the Data Grid Again
                    UpdateProduct update = new UpdateProduct();
                    DataTable data = update.ShowData();
                    datagridUpdate.DataSource = data;

                    textBoxProductName.Clear();
                    textBoxProductPrice.Clear();
                    textBoxProductStock.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid  productname");
                }
            }


            




        }

        private void textBoxProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
