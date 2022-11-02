
using System.Data;
using System.Data.SqlClient;


namespace Billing
{
    internal class NewProduct
    {
        string str = @"data source = (localdb)\MSSQLLocalDB; database = POS; integrated security = SSPI ";
        SqlConnection connection;
        SqlCommand command;

        public NewProduct()
        {
            connection = new SqlConnection(str);
            

        }


        //Add New Product From The DataBase Parent Table
        public bool AddNewProduct(string productname, string dateproductaddded)
        {
            int x = 0;
            try
            {
                connection.Open();
                string sql = "insert into Product values(@productname,@dateproductaddded)";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productname", productname);
                command.Parameters.AddWithValue("@dateproductaddded", dateproductaddded);
                x = command.ExecuteNonQuery();
            }
            catch
            {
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



        //Delete Product

        public bool DeleteNew(string productname)
        {
            int x = 0;
            try
            {
                connection.Open();
                string sql = "delete Product where pname = @productname";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@productname", productname);
                x = command.ExecuteNonQuery();
            }
            catch
            {
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

        //Loader Product From The DataBase


        public DataTable ShowData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                string sql = "select * from Product";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException s)
            {
                throw new Exception(s.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }

}

