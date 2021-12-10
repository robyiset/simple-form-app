using Crud_With_C.Models;
using Crud_With_C.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_With_C
{
    public partial class frm_inventory_list : Form
    {
        public frm_inventory_list()
        {
            InitializeComponent();
        }

        private void btn_gudang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lb_id_gudang.Text))
            {
                session.id_gudang = Convert.ToInt32(lb_id_gudang.Text);
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    session.nama_gudang = api.GetContent("gudang?id=" + lb_id_gudang.Text).ReadAsAsync<string>().Result;

                    Hide();
                    frm_inventory_control frm1 = new frm_inventory_control();
                    frm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Unable to display inventory list ");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Hide();
            frm_login frm2 = new frm_login();
            frm2.Show();
        }

        private void postgudang()
        {
            ConnectionAPI api = new ConnectionAPI();
            try
            {
                tbl_gudang tbl = new tbl_gudang
                {
                    nama_gudang = txt_nama_gudang.Text,
                    alamat = txt_alamat.Text,
                    create_user = session.username
                };
                api.PostResponse("gudang", tbl);

                MessageBox.Show("Successfully Inserted!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            if (!string.IsNullOrEmpty(txt_nama_gudang.Text) && !string.IsNullOrEmpty(txt_alamat.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                if (api.GetContent("gudang?name_check=" + txt_nama_gudang.Text).ReadAsAsync<bool>().Result == true)
                {
                    if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        postgudang();
                    }
                }
                else
                {
                    postgudang();
                }
                
            }
            else
            {
                MessageBox.Show("Please filled entire textboxes!");
            }
            lb_loading.Text = string.Empty;
            BindData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            lb_loading.Text = "Loading...";
            if (!string.IsNullOrEmpty(lb_id_gudang.Text) && !string.IsNullOrEmpty(txt_nama_gudang.Text) && !string.IsNullOrEmpty(txt_alamat.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("gudang?id_check=" + lb_id_gudang.Text).ReadAsAsync<bool>().Result == true)
                    {
                        tbl_gudang tbl = new tbl_gudang
                        {
                            id_gudang = Convert.ToInt32(lb_id_gudang.Text),
                            nama_gudang = txt_nama_gudang.Text,
                            alamat = txt_alamat.Text,
                            create_user = session.username
                        };
                        api.PutResponse("gudang", tbl);

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
            if (int.TryParse(lb_id_gudang.Text, out _) && !string.IsNullOrEmpty(lb_id_gudang.Text))
            {
                if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionAPI api = new ConnectionAPI();
                    try
                    {
                        if (api.GetContent("gudang?id_check=" + lb_id_gudang.Text).ReadAsAsync<bool>().Result == true)
                        {
                            api.DeleteResponse("gudang?id=" + lb_id_gudang.Text);
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
            List<vw_index_gudang> tbl = new List<vw_index_gudang>();
            if (!string.IsNullOrEmpty(txt_search.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    tbl = api.GetContent("gudang?search=" + txt_search.Text).ReadAsAsync<List<vw_index_gudang>>().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message);
                }
                lb_loading.Text = string.Empty;
                dataIndexGudang.DataSource = new BindingSource(tbl, "");
            }
            else
            {
                BindData();
            }
        }

        private void BindData()
        {
            lb_loading.Text = "Loading...";
            ConnectionAPI api = new ConnectionAPI();
            List<vw_index_gudang> lst_tbl = new List<vw_index_gudang>();
            try
            {
                lst_tbl = api.GetContent("gudang").ReadAsAsync<List<vw_index_gudang>>().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message);
            }
            lb_loading.Text = string.Empty;
            dataIndexGudang.DataSource = new BindingSource(lst_tbl, "");
        }

        private void frm_inventory_control_list_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(session.username))
            {
                Hide();
                frm_login frm2 = new frm_login();
                frm2.Show();
            }
            else
            {
                BindData();
            }
        }

        private void dataIndexGudang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_id_gudang.Text = dataIndexGudang.CurrentRow.Cells[0].Value.ToString();
            txt_nama_gudang.Text = dataIndexGudang.CurrentRow.Cells[1].Value.ToString();
            txt_alamat.Text = dataIndexGudang.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
