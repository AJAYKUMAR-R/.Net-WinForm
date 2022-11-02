using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Billing
{
    

    internal class RegisterUser
    {
        /// <summary>
        ///  Register  The user in the DataBase for Admin To acess this Application - UserRegisterForm
        /// </summary>

        SqlConnection connection;
        SqlCommand command;
        string connectionstring = @"Data Source = (localdb)\MSSQLLocalDB;database = POS;integrated security = SSPI";
        string sql = "";

        public RegisterUser()
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
                
                 
            }
            catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }

        }


        public bool Registeruser(string username,string role,string userpassword,string usermobileno)
        {

           
            int insertRowCount = 0;


            try
            {
                sql = "insert into RegisterUser values(@name,@mobileno,@password,@role);";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@password", userpassword);
                command.Parameters.AddWithValue("@mobileno", usermobileno);
                command.Parameters.AddWithValue("@role", role);
                insertRowCount = command.ExecuteNonQuery();
            }
            catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            
            if(insertRowCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

           


        }
    }

    /// <summary>
    ///  Regex for Register  The user in the DataBase for Admin To acess this Application - UserRegisterForm
    /// </summary>
    /// 

    class RegexRegister
    {
        public bool TextUser(string textuser)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]{3,58}");
            return regex.IsMatch(textuser);
        }


       

        public bool TextPasssword(string TextPassword)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]{3,15}$");
            return regex.IsMatch(TextPassword);
        }

        public bool Mobile(string mobile)
        {
            Regex regex = new Regex(@"^[6-9]{1}[0-9]{9}$");
            return regex.IsMatch(mobile);
        }
    }
}
