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
    internal class dal_login
    {
        dal_connection connection = new dal_connection();

        public bool login(bll_administrator administrator)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Administrador WHERE nombre=@name and contraseña=@password");
            cmd.Parameters.AddWithValue("@name", administrator.name);
            cmd.Parameters.AddWithValue("@password", administrator.password);

            int rowCount = (int) connection.ExecuteScalar(cmd);
            return rowCount > 0;
        }
    }
}
