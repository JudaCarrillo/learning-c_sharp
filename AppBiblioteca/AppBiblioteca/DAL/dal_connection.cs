using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// import library to access data
using System.Data;
using System.Data.SqlClient;

namespace AppBiblioteca.DAL
{
    internal class dal_connection
    {
        // connection to SQL Server
        private string chainConnection = "data source=.; initial catalog=bdbiblioteca; integrated security=true";
        // create connection varible
        SqlConnection connection;

        // create method to establish connection
        public SqlConnection Connect()
        {
            this.connection = new SqlConnection(chainConnection);
            return connection;
        }

        // create method to fetch the data
        public DataSet ExecQuery(SqlCommand cmd)
        {
            // create virtual table
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                // set connection path to command
                cmd.Connection = Connect();
                adapter.SelectCommand = cmd; // assign sql command 
                connection.Open(); // open connection
                adapter.Fill(ds); // filling the table with the data
                connection.Close(); // close connection 

                return ds; // return the table with data
            }
            catch (Exception ex)
            {
                return ds;
            }

        }

        public bool ExecCommandNoReturnOfData (SqlCommand cmd)
        {
            cmd.Connection = Connect();
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            using (SqlConnection connection = Connect())
            {
                connection.Open();
                cmd.Connection = connection;
                result = cmd.ExecuteScalar();
            }
            return result;
        }


    }

}
