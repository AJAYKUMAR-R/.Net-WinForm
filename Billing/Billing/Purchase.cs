using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Billing
{
    internal class Purchase
    {
        string connectionstring = @"Data Source = (localdb)\MSSQLLocalDB;database = POS;integrated security = SSPI";
        SqlConnection connection;
        SqlCommand command;
        string SqlCommand = "";

      

        public Purchase()
        {
            //Exception For Connetion
            try
            {

                connection = new SqlConnection(connectionstring);


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public DataTable CoustomerRecords(string billdate)
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                string sql = "select * from OrderTable where bildate = '" + billdate + "'";
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

        public DataTable CoustomerRecordsPrice(decimal price)
        {
            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                string sql = "select * from OrderTable where price >= " + price;
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
