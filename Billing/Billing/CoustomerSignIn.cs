
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Billing
{
    public class CoustomerSignIn
    {
        string connectionstring = @"Data Source = (localdb)\MSSQLLocalDB;database = POS;integrated security = SSPI";
        SqlConnection connection;
        SqlCommand command;
        string SqlCommand = "";

        

        public CoustomerSignIn()
        {
            //Exception For Connetion
            try
            {
               
                connection = new SqlConnection(connectionstring);  
                
               
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message); 
            }
        }


        /// <summary>
        /// Let new customer To Register - CregisterForm
        /// </summary>
        public bool AddDataBase(string nameuser,string useremail,string usermobile,string useraddress)
        {
            int x = 0;


            connection.Open();
            SqlCommand = "insert into coustomerRegister (custname,customereamil,customermobileno,customeraddress) values(@name,@email,@mobileno,@address)";
            command = new SqlCommand(SqlCommand, connection);
            command.Parameters.AddWithValue("@name", nameuser);
            command.Parameters.AddWithValue("@email", useremail);
            command.Parameters.AddWithValue("@mobileno", usermobile);
            command.Parameters.AddWithValue("@address", useraddress);


            //Exception for commnand 
            try
            {
                
                x = command.ExecuteNonQuery();
                
            }catch(SqlException exp)
            {
                MessageBox.Show("Phone Number has been Used Alredy");
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

        //Showing Customer Records From DataBase in Billing

        public DataTable CoustomerRecords()
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                string sql = "select * from OrderTable";
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
    /// <summary>
    /// Regex For CustomerSinngUp
    /// </summary>
    class CoustomerRegex
    {
        public bool Username(string textuser)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3,58}");
            return regex.IsMatch(textuser);
        }


        public bool UserMail(string textuser)
        {
            Regex regex = new Regex(@"^[a-z0-9]+[@](gmail|yahoo)[.](com|in)$");
            return regex.IsMatch(textuser);
        }
        public bool Mobile(string mobile)
        {
            Regex regex = new Regex(@"^[6-9]{1}[0-9]{9}$");
            return regex.IsMatch(mobile);
        }
        public bool Address(string TextPassword)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+");
            return regex.IsMatch(TextPassword);
        }

       
    }
}
