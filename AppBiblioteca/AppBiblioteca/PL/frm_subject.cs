using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// import library to establish connection
using System.Data.SqlClient;
using AppBiblioteca.DAL;
using AppBiblioteca.BLL;

namespace AppBiblioteca.PL
{
    public partial class frm_subject : Form
    {
        dal_subject o_dal_subject;

        public frm_subject()
        {
            o_dal_subject = new dal_subject();
            InitializeComponent();
            FillGrid();
        }

        public void FillGrid ()
        {
            dgvMateria.DataSource = o_dal_subject.ShowData().Tables[0];
        }

        private bll_subject RecoverInformation()
        {
            bll_subject bll_Subject = new bll_subject();
            int code = 0; int.TryParse(txtCode.Text, out code);
            bll_Subject.code = code;
            bll_Subject.materia = txtMateria.Text;
            return bll_Subject;
        }

        private void frm_materias_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RecoverInformation();
            dal_connection connection = new dal_connection();
            o_dal_subject.Add(RecoverInformation());
            FillGrid();
            MessageBox.Show("Registrado con éxito");
        }

        private void dgvMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtCode.Text = dgvMateria.Rows[index].Cells[0].Value.ToString();
            txtMateria.Text = dgvMateria.Rows[index].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            o_dal_subject.Delete(RecoverInformation());
            FillGrid();
            MessageBox.Show("Eliminado con éxito");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            o_dal_subject.Update(RecoverInformation());
            FillGrid();
            MessageBox.Show("Actualizado con éxito");
        }
    }
}
