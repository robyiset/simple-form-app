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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username or password invalid!");
            Hide();
            frm_inventory_control_list frm4 = new frm_inventory_control_list();
            frm4.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Hide();
            frm_register frm4 = new frm_register();
            frm4.Show();
        }
    }
}
