using Crud_With_C.Models;
using Crud_With_C.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Crud_With_C
{
    public partial class frm_inventory_control_1 : Form
    {
        public frm_inventory_control_1()
        {
            InitializeComponent();
        }

        private void frm_inventory_control_1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(session.username) || !string.IsNullOrEmpty(session.nama_gudang) || session.id_gudang != null || session.id_gudang > 0)
            {
                lb_title.Text = session.nama_gudang;
                BindData();
            }
            else
            {
                Hide();
                frm_login frm2 = new frm_login();
                frm2.Show();
            }
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            if (!string.IsNullOrEmpty(txt_nama_barang.Text) && !string.IsNullOrEmpty(txt_jumlah.Text) && int.TryParse(txt_jumlah.Text, out _))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    tbl_inventory tbl = new tbl_inventory
                    {
                        nama_barang = txt_nama_barang.Text,
                        jumlah = Convert.ToInt32(txt_jumlah.Text),
                        create_user = session.username,
                        id_gudang = Convert.ToInt32(session.id_gudang)
                    };
                    api.PostResponse("inventory", tbl);

                    MessageBox.Show("Successfully Inserted!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please file the textboxes!");
            }
            lb_loading.Text = string.Empty;
            BindData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            if (!string.IsNullOrEmpty(lb_id_barang.Text) && !string.IsNullOrEmpty(txt_nama_barang.Text) && !string.IsNullOrEmpty(txt_jumlah.Text) && int.TryParse(txt_jumlah.Text, out _))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("inventory?id_check=" + lb_id_barang.Text + "&id_gudang=" + session.id_gudang).ReadAsAsync<bool>().Result == true)
                    {
                        tbl_inventory tbl = new tbl_inventory
                        {
                            id_barang = Convert.ToInt32(lb_id_barang.Text),
                            nama_barang = txt_nama_barang.Text,
                            jumlah = Convert.ToInt32(txt_jumlah.Text),
                            create_user = session.username
                        };
                        api.PutResponse("inventory", tbl);

                        MessageBox.Show("Successfully Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Item not found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please file the textboxes!");
            }
            lb_loading.Text = string.Empty;
            BindData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            if (int.TryParse(lb_id_barang.Text, out _) && !string.IsNullOrEmpty(lb_id_barang.Text))
            {
                if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionAPI api = new ConnectionAPI();
                    try
                    {
                        if (api.GetContent("inventory?id_check=" + lb_id_barang.Text + "&id_gudang=" + session.id_gudang).ReadAsAsync<bool>().Result == true)
                        {
                            api.DeleteResponse("inventory?id=" + lb_id_barang.Text);
                            MessageBox.Show("Successfully Deleted!");
                        }
                        else
                        {
                            MessageBox.Show("Item Not Found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error message: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Put Number ID!");
            }
            lb_loading.Text = string.Empty;
            BindData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            List<tbl_inventory> tbl = new List<tbl_inventory>();
            if (!string.IsNullOrEmpty(txt_search.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    tbl = api.GetContent("inventory?search=" + txt_search.Text + "&id_gudang=" + session.id_gudang).ReadAsAsync<List<tbl_inventory>>().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                }

                lb_loading.Text = string.Empty;
                dataGridView1.DataSource = new BindingSource(tbl, "");
            }
            else
            {
                BindData();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            frm_inventory_control_list frm4 = new frm_inventory_control_list();
            frm4.Show();
        }

        private void BindData()
        {
            lb_loading.Text = "Loading...";
            ConnectionAPI api = new ConnectionAPI();
            List<tbl_inventory> lst_tbl = new List<tbl_inventory>();
            try
            {
                lst_tbl = api.GetContent("inventory?id_gudang=" + session.id_gudang).ReadAsAsync<List<tbl_inventory>>().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message);
            }
            lb_loading.Text = string.Empty;
            dataGridView1.DataSource = new BindingSource(lst_tbl, "");
        }
    }
}
