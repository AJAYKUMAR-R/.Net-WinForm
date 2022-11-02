
using System.Data.SqlClient;


namespace Billing
{
    internal class BillCalculate
    {
        string str = @"data source = (localdb)\MSSQLLocalDB; database = POS; integrated security = SSPI ";
        SqlConnection connection;
        SqlDataReader reader;
        SqlCommand command;

        public BillCalculate()
        {
            connection = new SqlConnection(str);
            

        }

        //Geting All the ProductID and Name from The DataBase
        public List<Product> ProductTablInBill()
        {
            List<Product> productslist = new List<Product>();

            try
            {
                connection.Open();
                string sql = "select * from productcategories";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Produccattid = reader[1].ToString();
                    product.Pcatname = reader[2].ToString();
                    product.Stockunit = Convert.ToInt32(reader[3].ToString());
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

        public string StockCount(int id)
        {
            try
            {
                connection.Open();
                string sql = "select stockunit from Product where productid = @id;";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                string strings = "";
                while (reader.Read())
                {
                    strings += (reader[0].ToString());
                };
                return strings;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        //Retriving the Selected productid Details From The Database
        public List<string> ItemAdded(string id,int quantity)
        {
            try
            {
                connection.Open();
                string sql = "select productcatid,catename,price from productcategories  where productcatid = @id";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                List<string> strings = new List<string>();


                while (reader.Read())
                {
                    strings.Add(reader[0].ToString());
                    strings.Add(reader[1].ToString());
                    strings.Add(reader[2].ToString());
                   

                };
                //Here Calculating Total Amount
                strings.Add(Convert.ToString(quantity));
                decimal totalquantity = (quantity * Convert.ToDecimal(strings[2]));
                strings.Add(Convert.ToString(totalquantity));

                return strings;
            }catch(SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        //Searching The Coustomer ID AND Name from Database Table Singup

        public List<string> SearchCoustomerID(string mobileno)
        {
            try
            {
                connection.Open();
                string sql = "select custname,custid from coustomerRegister where customermobileno = @mobileno";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                reader = command.ExecuteReader();
                List<string> strings = new List<string>();
                while (reader.Read())
                {
                   strings.Add(reader[0].ToString());
                    strings.Add(reader[1].ToString());
                };

                return strings;
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        //Generating Orderid From Database from Last Count OF the Table By increment orderid is variable

        public int AddOredridGEnerator()
        {
            try
            {
                connection.Open();
                //Generating Orderid From Database from Last Count OF the Table By increment orderid is variable
                string sql = "SELECT TOP 1 ordrderid FROM OrderTable ORDER BY ordrderid DESC; ";
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
                int orderid = 0;
                while (reader.Read())
                {
                    orderid = Convert.ToInt32(reader[0].ToString());
                }
                //Here Increasing The Count
                orderid = orderid + 1;
                return orderid;
            }catch(SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }


        //Adding Bill Record To the Orderd Table in Database
        public bool Payslip(int orderid,int coustid,string productDetails,decimal price,string date)
        {
            //Adding bill to Orderid Table;
            int insertRowCount = 0;

            try
            {
                connection.Open();
                string sql = "insert into OrderTable values(@orderid,@coustid,@productDetails,@price,@date)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@orderid", orderid);
                command.Parameters.AddWithValue("@coustid", coustid);
                command.Parameters.AddWithValue("@productDetails", productDetails);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@date", date);
                insertRowCount = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
            if (insertRowCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Reduse StockCount From The Database Table Product
        public bool ReduceStockCount(string id, int quantity)
        {
            try
            {
                connection.Open();
                string sql = "update  productcategories set stocks = stocks - @quantity  where productcatid = @id;";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@quantity", quantity);
                int count = command.ExecuteNonQuery();
                


                if(count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             

               
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }
        }

        //public DataTable ShowData()
        //{
        //    try
        //    {
        //        connection.Open();
        //        DataTable dt = new DataTable();
        //        string sql = "select productid,stockunit from Product";
        //        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //    catch (SqlException s)
        //    {
        //        throw new Exception(s.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}

    }

    class Product
    {
        string produccattid;
        string pcatname;
        int stockunit;

       




        public string Produccattid
        {
            get { return produccattid; }
            set { produccattid = value; }
        }


        public string Pcatname
        {
            get { return pcatname; }
            set { pcatname = value; }
        }

        public int Stockunit
        {
            get { return stockunit; }
            set { stockunit = value; }
        }
    }
}

