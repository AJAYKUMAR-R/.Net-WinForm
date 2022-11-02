
using System.Data.SqlClient;
using System.Data;


namespace Billing
{
    internal class UpdateProduct
    {
        /// <summary>
        /// Showing the Already Entered Product - UpdateProduct Form
        /// </summary>

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string conncetingstring = @"data source = (localdb)\MSSQLLocalDB; database = POS; integrated security = SSPI;";


        public UpdateProduct()
        {
            connection = new SqlConnection(conncetingstring);
           
        }


        //Show All Details From Loading - Update ProductForm
        public DataTable ShowData()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                string sql = "select * from Productcategories";
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

        /// <summary>
        /// Searching the Already Entered Product using Categories Name - UpdateProduct Form
        /// </summary>
        public List<string> ProductSearch(string categoriesname)
        {
            try
            {
                connection.Open();
                string sql = "select catename,stocks,price from Productcategories where catename = @categoriesname";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@categoriesname", categoriesname);
                reader = command.ExecuteReader();
                List<string> strings = new List<string>();
                while (reader.Read())
                {
                    strings.Add(reader[0].ToString());
                    strings.Add(reader[1].ToString());
                    strings.Add(reader[2].ToString());
                   

                };

                return strings;
            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Updating the Already Entered Product - UpdateProduct Form
        /// </summary>

        public bool UpdateProductDetails(string productname,int stockunit,decimal productprice)
        {
            int insertRowCount = 0;

            try
            {
                connection.Open();
                string sql = "update Productcategories set stocks =@stockunit, price = @productprice where catename = @catname";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@catname", productname);
                command.Parameters.AddWithValue("@stockunit", stockunit);
                command.Parameters.AddWithValue("@productprice", productprice);
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

        /// <summary>
        ///  DElete The Product From The User
        /// </summary>
       
        public bool DeleteProductDetails(string catename)
        {
            int deleteRowCount = 0;
            try
            {
                connection.Open();
                string sql = "delete Productcategories where  catename = @catename";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@catename", catename);
                deleteRowCount = command.ExecuteNonQuery();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message);
                
            }
            finally
            {
                connection.Close();
            }
            if (deleteRowCount == 1)
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
