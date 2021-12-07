using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_With_C
{
    public partial class frm_inventory_control_list : Form
    {
        public frm_inventory_control_list()
        {
            InitializeComponent();
        }

        private void btn_gudang_1_Click(object sender, EventArgs e)
        {
            frm_inventory_control_1 frm1 = new frm_inventory_control_1();
            frm1.Show();
        }

        private void btn_gudang_2_Click(object sender, EventArgs e)
        {
            frm_inventory_control_2 frm5 = new frm_inventory_control_2();
            frm5.Show();
        }

        private void btn_gudang_3_Click(object sender, EventArgs e)
        {
            frm_inventory_control_3 frm6 = new frm_inventory_control_3();
            frm6.Show();
        }

        private void btn_gudang_4_Click(object sender, EventArgs e)
        {
            frm_inventory_control_4 frm7 = new frm_inventory_control_4();
            frm7.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
