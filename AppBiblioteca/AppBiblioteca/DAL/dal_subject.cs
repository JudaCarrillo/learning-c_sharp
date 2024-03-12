using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// including ado .NET libraries
using System.Data;
using System.Data.SqlClient;
using AppBiblioteca.BLL;

namespace AppBiblioteca.DAL
{
    internal class dal_subject
    {
        dal_connection connection = new dal_connection();

        public DataSet ShowData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Materia");
            return connection.ExecQuery(cmd);
        }

        public bool Add (bll_subject new_bll_Subject)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Materia values(@materia)"); 
            cmd.Parameters.AddWithValue("@materia", new_bll_Subject.materia);
            return connection.ExecCommandNoReturnOfData(cmd);
        }

        public int Delete(bll_subject new_bll_subject)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Materia WHERE codigo=@code");
            cmd.Parameters.AddWithValue("@code", new_bll_subject.code);
            return connection.ExecCommandNoReturnOfData(cmd) ? 1: 0;
        }

        public int Update(bll_subject new_bll_subject)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Materia SET nombre=@materia WHERE codigo=@code");
            cmd.Parameters.AddWithValue("@materia", new_bll_subject.materia);
            cmd.Parameters.AddWithValue("@code", new_bll_subject.code);
            return connection.ExecCommandNoReturnOfData(cmd) ? 1 : 0;
        }
    }
}
