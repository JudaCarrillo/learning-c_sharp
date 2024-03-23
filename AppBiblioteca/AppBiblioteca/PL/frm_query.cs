using AppBiblioteca.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBiblioteca.PL
{
    public partial class frm_query : Form
    {

        dal_category categories = new dal_category();

        public frm_query()
        {
            InitializeComponent();
            FillComboBox();
        }

        public void FillComboBox()
        {
            List<string> categoryNames = categories.GetCategoryNames();
            comboBox1.DataSource = categoryNames;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedValue = comboBox1.SelectedValue;
            dataGridView1.DataSource = categories.ShowData(selectedValue).Tables[0];
        }
    }
}
