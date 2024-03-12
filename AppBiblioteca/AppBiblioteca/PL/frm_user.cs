using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppBiblioteca.DAL;
using AppBiblioteca.BLL;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AppBiblioteca.PL
{
    public partial class frm_user : Form
    {

        dal_user o_dal_user;

        public frm_user()
        {
            this.o_dal_user = new dal_user();
            InitializeComponent();
            FillGrid();
        }

        public void FillGrid()
        {
            dgvUser.DataSource = o_dal_user.ShowData().Tables[0];
        }

        private bll_user RecoverInformation()
        {
            bll_user o_bll_user = new bll_user();
            int dni = 0; int.TryParse(txtDNI.Text, out dni);
            o_bll_user.DNI = dni;
            o_bll_user.name = txtName.Text;
            o_bll_user.surname = txtSurname.Text;
            o_bll_user.direction = txtDirection.Text;
            o_bll_user.occupation = txtOccupation.Text;

            return o_bll_user;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_user_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            o_dal_user.Update(RecoverInformation());
            FillGrid();
            MessageBox.Show("Actualizado con éxito");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RecoverInformation();
            dal_connection connection = new dal_connection();
            o_dal_user.Add(RecoverInformation());
            FillGrid();
            MessageBox.Show("Registrado con éxito");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            o_dal_user.Delete(RecoverInformation());
            FillGrid();
            MessageBox.Show("Eliminado con éxito");
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtDNI.Text = dgvUser.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvUser.Rows[index].Cells[1].Value.ToString();
            txtSurname.Text = dgvUser.Rows[index].Cells[2].Value.ToString();
            txtDirection.Text = dgvUser.Rows[index].Cells[3].Value.ToString();
            txtOccupation.Text = dgvUser.Rows[index].Cells[4].Value.ToString();
        }
    }
}
