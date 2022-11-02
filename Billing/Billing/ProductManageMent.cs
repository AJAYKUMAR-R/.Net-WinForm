
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Billing
{
    /// <summary>
    ///   Database Connection For Product Adding To The DataBase
    /// </summary>
    internal class ProductManagement
    {
        string str = @"data source = (localdb)\MSSQLLocalDB; database = POS; integrated security = SSPI ";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public ProductManagement()
        {
            connection = new SqlConnection(str);
            

        }



        //Showing All The product in Combobox  From Loading
        
        public List<TempProduct> ProductTable()
        {
            List<TempProduct> productslist = new List<TempProduct>();

            try
            {
                connection.Open();
                string sql = "select * from Product";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TempProduct product = new TempProduct();
                    product.ProductID = Convert.ToInt32(reader[0].ToString());
                    product.ProductName = reader[1].ToString();
                    productslist.Add(product);

                }
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return productslist;    

            


        }


        //Product Adding to the Database
        public bool ProductDetails(int productid, string catename, int stocks, decimal productprice,string date)
        {
            int x = 0;
            try
            {
                connection.Open();
                //Generating ProductCatigoresId
                string productcatid = catename.Substring(0, 4) + "_" + productid;

                
                string sql = "insert into Productcategories (productid,productcatid,catename,stocks,price,dateproductcategoriesaddded)  values (@productid,@productcatid,@catename,@stocks,@price,@dateproductcategoriesaddded);";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productid", productid);
                command.Parameters.AddWithValue("@productcatid", productcatid);
                command.Parameters.AddWithValue("@catename", catename);
                command.Parameters.AddWithValue("@stocks", stocks);
                command.Parameters.AddWithValue("@price", productprice);
                command.Parameters.AddWithValue("@dateproductcategoriesaddded", date);
                x = command.ExecuteNonQuery();

            }
            catch(SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }



           

            if (x == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //Product Table class

    class TempProduct
    {
        int productid;
        string productname;

        public int ProductID
        {
            get { return productid; }
            set { productid = value; }
        }

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

       
    }







    class ProductRegex
    {
        //Regex For Update Product and Add Product
        public bool ProductName(string productname)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{4,50}$");
            return regex.IsMatch(productname);
        }

        public bool ProductCategories(string productDescription)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+");
            return regex.IsMatch(productDescription);
        }

        public bool productStockCount(string productStockCount)
        {
            Regex regex = new Regex(@"^[\d]+$");
            return regex.IsMatch(productStockCount);
        }

        public bool productPrice(string productPrice)
        {
            Regex regex = new Regex(@"^[1-9]{1}[0-9]{1,53}.[0-9]{1,45}$");
            bool x = regex.IsMatch(productPrice);
            Regex regexone = new Regex(@"^[1-9]{1}[0-9]{1,53}$");
            bool y = regexone.IsMatch(productPrice);
            if (x || y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
