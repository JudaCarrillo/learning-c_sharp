using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppBiblioteca.BLL;
using System.Data;
using System.Data.SqlClient;

namespace AppBiblioteca.DAL
{
    internal class dal_category
    {

        dal_connection connection = new dal_connection();

        public List<string> GetCategoryNames()
        {
            List<string> list = new List<string>();

            SqlCommand cmd = new SqlCommand("SELECT nombre FROM Materia");
            DataSet result = connection.ExecQuery(cmd);

            if (result != null && result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        string name = item.ToString();
                        list.Add(name);
                    }
                }
            }

            return list;
        }

        public string GetCategoriesId(string name) {

            string id = "";

            SqlCommand cmd = new SqlCommand("SELECT Codigo FROM Materia WHERE nombre = @name");
            cmd.Parameters.AddWithValue("@name", name);
            DataSet result = connection.ExecQuery(cmd);

            if (result != null && result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in result.Tables[0].Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        id = item.ToString();
                    }
                }
            }

            return id;
        }

        public DataSet ShowData(object values)
        {


            Console.WriteLine(values.ToString());
            string value = values.ToString();
            string code = GetCategoriesId(value);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Libro WHERE CodigoMateria = @code");
            cmd.Parameters.AddWithValue("@code", code);
            return connection.ExecQuery(cmd);
        }
    }
}
