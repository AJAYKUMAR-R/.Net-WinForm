using System;
using System.Data.SqlClient;


namespace Billing
{
    internal class Login
    {
        /// <summary>
        /// Validating The User Admin For Allow to acess this Application - LoginCredential
        /// </summary>

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public Login()
        {
            try
            {
                string connectionstring = @"Data Source = (localdb)\MSSQLLocalDB;database = POS;integrated security = SSPI";
                connection = new SqlConnection(connectionstring);
                connection.Open();
            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        /// <summary>
        /// Validating The User Admin For Allow to acess this Application - LoginCredential
        /// </summary>

        public string LoginUser(string username , string password)
        {
            string role = "";
            try
            {
                string sql = "select * from RegisterUser where username = @username and userpassword = @userpassword ";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@userpassword", password);
                
               
            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
                
            }
            try
            {
                reader = command.ExecuteReader();
            }catch(SqlException exp)
            {
                MessageBox.Show(exp.Message);
            }
            if (reader.Read())
            {
                //Geting The Role From The User
                role = reader[3].ToString();
                return role;


            }
            else
            {
                return null;

            }
            
           
            
        } 
    }
}
