using System.Data;
using System.Text.RegularExpressions;
namespace Billing
{
    
    public partial class billForm : Form
    {
        //subtotal all over the Function
        decimal subtotal = 0;


        //coust Details For Runtime
        List<string> custdetails = new List<string>();  


        //Count the Quantity - 145
        int quantityCount = 0;

        //products For Iterating and Showing in Form From The DataBase to Store in Object For Manupulation - 48
        //productid and stocks stored as array of Object for Runtime Manupulation
        List<Product> products = new List<Product>();

       

        //Selected Product ID 
        string selectedValue;
        public billForm()
        {
            InitializeComponent();
            
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void billForm_Load(object sender, EventArgs e)
        {
            //Disable the Button When there is No Product Is Added
            btnPay.Enabled = false;
            btnPay.ForeColor = Color.DimGray;


            //Loading Product Id in ComboBox Extrating from DataBase Storing In Collection For Runtime Memory To Manupulate
            BillCalculate billCalculate = new BillCalculate();
            products = billCalculate.ProductTablInBill();
            foreach (var item in products)
            {
                comboBoxProductId.Items.Add(item.Pcatname);
            }

            //Geting the OrderId From The DataBase and Adding Value 1
            int orderid = billCalculate.AddOredridGEnerator();
            labelorder.Text = orderid.ToString();


            //Disable Clear Button

            if (dataGridViewBillTable.Rows.Count <= 1)
            {
                //disable the Button
                button1.Enabled = false;
                button1.ForeColor = Color.Gray;
            }
            



        }

        private void comboBoxProductId_SelectedValueChanged(object sender, EventArgs e)
        {
           

            //selected Value For Maintaining Productid store in Instant Variable to used in All over the Fuction
            string pactname = comboBoxProductId.SelectedItem.ToString();
            foreach (var item in products)
            {
                if(item.Pcatname == pactname)
                {
                   
                    selectedValue = item.Produccattid;
                }
            }


            //New Method For Iterating From Runtime Collection to Show in Label For Available Stock
            foreach (var item in products)
            {
                if(item.Produccattid == selectedValue)
                {
                    labstockcount.Text = item.Stockunit.ToString();
                    
                }
            }
            



        }

        private void comboBoxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //add product button
        private void button1_Click(object sender, EventArgs e)
        {
            
           
                //Not Allowing to Pay when there is no product is being Selected So Disable the Button
                if (dataGridViewBillTable.Rows.Count > 0)
                {
                    //Enable the Button
                    btnPay.Enabled = true;
                    btnPay.ForeColor = Color.Black;
                }



            //Enable the clear button
            if (dataGridViewBillTable.Rows.Count <= 1)
            {
                //disable the Button
                button1.Enabled = true;
                button1.ForeColor = Color.Black;
            }



            //Quantity Text value Check if null or negative Value Using Regex Not like this 0,"" 


            if (textBoxQuantity.Text == "" || !RegexQuantity(textBoxQuantity.Text) || Convert.ToInt32(textBoxQuantity.Text) == 0)
                {
                    MessageBox.Show("Please Enter the Quantity or In a Correct Format");
                }
                else
                {
                //iterate to verify the Selected Quantity do not exceded from Stock Value;
                foreach (var item in products)
                {
                    if (item.Produccattid == selectedValue)
                    {

                        //Validating Stock Count  To accept the Quantity it Should be Greater
                        if (Convert.ToInt32(textBoxQuantity.Text) < item.Stockunit)
                        {


                            //Update the quantity So that it Reduse From the Database
                            quantityCount = Convert.ToInt32(textBoxQuantity.Text);



                            // Geting Id Text if it is Not Selected In The ComboBox
                            if (comboBoxProductId.SelectedItem == null)
                            {
                                MessageBox.Show("Enter ProductID");
                            }
                            else
                            {
                               

                                //Creating Object For the Method
                                BillCalculate billCalculate = new BillCalculate();

                                //return List To display in Datagridview return as List from The database with total Amount Multiplied With Quantity
                                List<string> list = billCalculate.ItemAdded(selectedValue, quantityCount);




                                //Appending To Datagrid 
                                dataGridViewBillTable.Rows.Add(list[0], list[1], list[2], list[3], list[4]);



                                //Displaying SubTotal in RichText box alredy value present in richtext box Convert into Decimal and add each row Totalprice 
                                subtotal = Convert.ToDecimal(textotal.Text) + Convert.ToDecimal(list[4]);
                                textotal.Text = subtotal.ToString();

                                ////Maintainig The Form Logically For The User it Won't Reduse untill User Click PayButton just for Reduse Dynamicallly for the User Not Go Beyond the Stock
                                item.Stockunit = (item.Stockunit - quantityCount);
                                labstockcount.Text = item.Stockunit.ToString();
                                
                                
                                

                            }
                        }
                        else
                        {
                            MessageBox.Show("Stock Out Of Range");
                        }

                    }
                }

               


            }
            
         

        }
        

        //Regex for Quantitycheck

        private bool RegexQuantity(string quantity)
        {
            //reg
            Regex regex = new Regex(@"^{1}[0-9]+$");
            return regex.IsMatch(quantity);
        }

        private void dataGridViewBillTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }



        //Pay button
        private void button2_Click(object sender, EventArgs e)
        {

            //Appending Bill details to the Orderid Table Bill store in Database

            //Checking the Details wether Coustomer id is Selected or Not
            if (labelcoustID.Text == "" || labelcoustID.Text == "Not found")
            {
                MessageBox.Show("Customer ID not in correct Format");
            }
            else
            {
                //Geting the OrderID from The Label
                int orderid = Convert.ToInt32(labelorder.Text);
                //Geting the Customerid from The coustdetails array in Search button
                int coustid = Convert.ToInt32(custdetails[1]);

                //Geting the totalprice  from The richtextbox
                decimal price = Convert.ToDecimal(textotal.Text);

                //Code for Updating Stock in Database temporary variable
                string quant = "";
                string id = "";
                 
                //String for Geting ProductDetails
                string productDetails = "";
                int len = dataGridViewBillTable.RowCount;

                //List for Reduce Stock Details ProductcatID From DAtagrid View
                List<string> coustcateid = new List<string>();

                //collection For Reduce StockDetails Quantity 
                List<int> quantity = new List<int>();
                for (int i = 0; i < len; i++)
                {
                    if (dataGridViewBillTable.Rows[i].IsNewRow == false)
                    {
                        quant = dataGridViewBillTable.Rows[i].Cells[3].Value.ToString();
                        quantity.Add(Convert.ToInt32(quant));
                        id = dataGridViewBillTable.Rows[i].Cells[0].Value.ToString();
                        coustcateid.Add(id);
                        productDetails = productDetails + dataGridViewBillTable.Rows[i].Cells[1].Value.ToString() + '\n';
                    }


                }
                //generating Current date
                DateTime date = DateTime.UtcNow.Date;
                string currentdate = date.ToString().Substring(0, 10);
                Console.WriteLine(currentdate);

                //Adding The Bill To The DataBase Ordertable
                BillCalculate billCalculate = new BillCalculate();
                bool check = billCalculate.Payslip(orderid, coustid, productDetails, price,currentdate);
                if (check)
                {
                    MessageBox.Show("Bill COmpleted");

                    //Connectig the Stored ProductCategoriesID array and Quantity To Database to Reduse the Stock
                    for (int i = 0; i < coustcateid.Count; i++)
                    {
                        billCalculate.ReduceStockCount(coustcateid[i], quantity[i]);
                    }

                    //Reloading The Form 
                    this.Controls.Clear();
                    InitializeComponent();
                    //Loading Product Id in ComboBox
                    products = billCalculate.ProductTablInBill();
                    foreach (var item in products)
                    {
                        comboBoxProductId.Items.Add(item.Pcatname);
                    }
                    // Again Generating Orderid From Data Base Fro The Next Coustomer;
                    int orderidload = billCalculate.AddOredridGEnerator();
                    labelorder.Text = orderidload.ToString();
                    //Not Allowing to Pay when there is no product is being Selected So Disable the Button when it is RElaoded
                    if (dataGridViewBillTable.Rows.Count <= 1)
                    {
                        //Enable the Button
                        btnPay.Enabled = false;
                        btnPay.ForeColor = Color.Black;
                    }
                    if (dataGridViewBillTable.Rows.Count <= 1)
                    {
                        //disable the Button
                        button1.Enabled = false;
                        button1.ForeColor = Color.Gray;
                    }


                }
                else
                {
                    MessageBox.Show("Bill not Completed");
                }


            }








        }


        //Search the Coustomer ID in Database Showing in a Label
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mobileno = textBoxMobile.Text;
            BillCalculate bill = new BillCalculate();
            try
            {
                custdetails = bill.SearchCoustomerID(mobileno);
                labelcoustID.Text = custdetails[0];
               
              
            }
            catch(Exception exp)
            {
                MessageBox.Show("Not Found");
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //While Deleting row Quantity Should Be Redused in Runtime Collection

            try

            {
               

                int index = dataGridViewBillTable.CurrentCell.RowIndex;
                string s = "";

                if (dataGridViewBillTable.Rows[index].IsNewRow == false)
                {

                   

                    string id = dataGridViewBillTable.Rows[index].Cells[0].Value.ToString();
                    int quantity = Convert.ToInt32(dataGridViewBillTable.Rows[index].Cells[3].Value.ToString());

                    foreach (var item in products)
                    {
                        if (item.Produccattid == id)
                        {
                            item.Stockunit = (item.Stockunit + quantity);
                            labstockcount.Text = item.Stockunit.ToString();
                            //stockcount = item.Stockunit;


                        }
                    }
                    
                    //Code for Maintainig subtotal and Remove the row From The Grid
                    s = dataGridViewBillTable.Rows[index].Cells[4].Value.ToString();
                    dataGridViewBillTable.Rows.RemoveAt(index);

                    //Reduse The Total AMount
                    decimal subtotalDelete = Convert.ToDecimal(s);
                    subtotal = subtotal - subtotalDelete;
                    textotal.Text = subtotal.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Row Not Properly Selected");
                return;
            }
            //Not Allowing to Pay when there is no product is being Selected So Disable the Button
            if (dataGridViewBillTable.Rows.Count <= 1)
            {
                //Enable the Button
                btnPay.Enabled = false;
                btnPay.ForeColor = Color.Black;
            }
            if (dataGridViewBillTable.Rows.Count <= 1)
            {
                //disable the Button
                button1.Enabled = false;
                button1.ForeColor = Color.Gray;
            }


        }


        //Viewbutton
        private void button2_Click_1(object sender, EventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.ShowDialog();
        }
    }
   
}
