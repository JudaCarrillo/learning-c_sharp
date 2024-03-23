using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppBiblioteca.BLL;
using AppBiblioteca.DAL;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AppBiblioteca.PL
{
    public partial class frm_login : Form
    {
        dal_login login = new dal_login();

        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bll_administrator RecoverInformation()
        {
            bll_administrator bll_admin = new bll_administrator();
            bll_admin.name = txtUser.Text;
            bll_admin.password = txtPassword.Text;
            return bll_admin;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            dal_connection connection = new dal_connection();
            bool isValid = login.login(RecoverInformation());

            if (!isValid)
            {
                MessageBox.Show("Credenciales incorrectas");
            } else
            {
                Form1 frm = new Form1();
                frm.Show();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
