

using System.Data;
using System.Text.RegularExpressions;

namespace Billing
{
    public partial class ProductDetails : Form
    {
        List<TempProduct> tempProducts = new List<TempProduct>();  
        
        string selectedvalue = "";

        public ProductDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Instant Variable 
           
            string cate = "";
            int stocks = 0;
            decimal price = 0;
            string date = dateTimePickerAddPcat.Text;
           
            ProductRegex regex = new ProductRegex();
            if (regex.ProductName(textCatgoriesName.Text))
            {
                labelproductDescriptioninvalid.Text = "";
                cate = textCatgoriesName.Text;
            }
            else
            {
                labelproductDescriptioninvalid.Text = "Min 4 Charcater or Invalid Password";
                return;
            }
            

            if (!regex.productStockCount(textStockUnit.Text) || textStockUnit.Text == "0")
            {
                labestockinvalid.Text = "Invalid Product Count";
                return;
            }
            else
            {
                labestockinvalid.Text = "";
                stocks = Convert.ToInt32(textStockUnit.Text);
            }

            if (!regex.productPrice(textPrice.Text))
            {
                labelpriceinvalid.Text = "Invalid Price ";
                return;
            }
            else
            {
                labelpriceinvalid.Text = "";
                price = Convert.ToDecimal(textPrice.Text);
            }

            foreach (var item in tempProducts)
            {

               if(item.ProductName ==  selectedvalue)
                {
                    
                    ProductManagement productManagement = new ProductManagement();
                    bool check = productManagement.ProductDetails(item.ProductID, cate, stocks, price,date);
                    if (check)
                    {
                        MessageBox.Show("Product Added");
                    }
                    else
                    {
                        MessageBox.Show("Product Not Added");
                    }
                    textCatgoriesName.Clear();
                    textStockUnit.Clear();
                    textPrice.Clear();
                }

               
            }
            


           

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //UpdateProductForm updateProductForm = new UpdateProductForm();
            //updateProductForm.ShowDialog();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            tempProducts = productManagement.ProductTable();
            foreach (var item in tempProducts)
            {
                comboBoxProductName.Items.Add(item.ProductName);
            }
        }

        private void comboBoxProductName_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedvalue = comboBoxProductName.SelectedItem.ToString();
        }
    }

   
}
