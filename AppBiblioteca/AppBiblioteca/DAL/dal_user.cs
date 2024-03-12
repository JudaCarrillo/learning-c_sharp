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
    internal class dal_user
    {
        dal_connection connection = new dal_connection();

        public DataSet ShowData ()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario");
            return connection.ExecQuery(cmd);
        }

        public bool Add(bll_user new_bll_User)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario values(@dni, @name, @surname, @direction, @occupation)");
            cmd.Parameters.AddWithValue("@dni", new_bll_User.DNI);
            cmd.Parameters.AddWithValue("@name", new_bll_User.name);
            cmd.Parameters.AddWithValue("@surname", new_bll_User.surname);
            cmd.Parameters.AddWithValue("@direction", new_bll_User.direction);
            cmd.Parameters.AddWithValue("@occupation", new_bll_User.occupation);
            return connection.ExecCommandNoReturnOfData(cmd);
        }

        public int Delete(bll_user new_bll_User)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE dni=@dni");
            cmd.Parameters.AddWithValue("@dni", new_bll_User.DNI);
            return connection.ExecCommandNoReturnOfData(cmd) ? 1 : 0;
        }

        public int Update(bll_user new_bll_User)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Usuario SET nombre=@name, apellidos=@surname, direccion=@direction, ocupacion=@occupation WHERE dni=@dni");
            cmd.Parameters.AddWithValue("@name", new_bll_User.name);
            cmd.Parameters.AddWithValue("@surname", new_bll_User.surname);
            cmd.Parameters.AddWithValue("@direction", new_bll_User.direction);
            cmd.Parameters.AddWithValue("@occupation", new_bll_User.occupation);

            cmd.Parameters.AddWithValue("@dni", new_bll_User.DNI);
            return connection.ExecCommandNoReturnOfData(cmd) ? 1 : 0;
        }

    }
}
