﻿using System;
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
    public partial class frm_inventory_control_2 : Form
    {
        public frm_inventory_control_2()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_inventory_control_list frm4 = new frm_inventory_control_list();
            frm4.Show();
        }
    }
}
