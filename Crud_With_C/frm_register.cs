using Crud_With_C.Models;
using Crud_With_C.Services;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Crud_With_C
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            frm_login frm2 = new frm_login();
            frm2.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            lb_registering.Text = "Registering...";
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text) && !string.IsNullOrEmpty(txt_re_password.Text) &&
                !string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(cb_gender.Text))
            {
                if (txt_password.ToString() == txt_re_password.ToString())
                {
                    ConnectionAPI api = new ConnectionAPI();
                    try
                    {
                        if (api.GetContent("user?username=" + txt_username.Text).ReadAsAsync<bool>().Result == false)
                        {
                            tbl_user tbl = new tbl_user
                            {
                                username = txt_username.Text,
                                email = txt_email.Text,
                                password = txt_password.Text,
                                gender = cb_gender.Text
                            };
                            api.PostResponse("user", tbl);

                            MessageBox.Show("Your account registered, please login to access");
                            Hide();
                            frm_login frm2 = new frm_login();
                            frm2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username already registered!");
                            lb_registering.Text = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error message: " + ex.Message);
                        lb_registering.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Password not match!");
                    lb_registering.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill all textboxes!");
                lb_registering.Text = string.Empty;
            }
        }
    }
}
