using Crud_With_C.Models;
using Crud_With_C.Services;
using System;
using System.Net.Http;
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
            validating();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Hide();
            frm_register frm4 = new frm_register();
            frm4.Show();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validating();
            }
        }

        private void validating()
        {
            lb_validate.Text = "Validating...";
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("user?username=" + txt_username.Text + "&password=" + txt_password.Text).ReadAsAsync<bool>().Result == true)
                    {
                        session.username = txt_username.Text;
                        lb_validate.Text = string.Empty;
                        Hide();
                        frm_inventory_list frm = new frm_inventory_list();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password invalid!");
                        lb_validate.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                    lb_validate.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please input your username and password!");
                lb_validate.Text = string.Empty;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validating();
            }
        }
    }
}
