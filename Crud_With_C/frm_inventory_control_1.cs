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

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id_barang.Text) && !string.IsNullOrEmpty(txt_nama_barang.Text) && !string.IsNullOrEmpty(txt_jumlah.Text) &&
                int.TryParse(txt_jumlah.Text, out _) && int.TryParse(txt_id_barang.Text, out _))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("inventory?id_check=" + txt_id_barang.Text).ReadAsAsync<bool>().Result == false)
                    {
                        tbl_inventory tbl = new tbl_inventory
                        {
                            id_barang = txt_id_barang.Text,
                            nama_barang = txt_nama_barang.Text,
                            jumlah = Convert.ToInt32(txt_jumlah.Text),
                            create_date = DateTime.Now
                        };
                        api.PostResponse("inventory", tbl);

                        MessageBox.Show("Successfully Inserted!");
                    }
                    else
                    {
                        MessageBox.Show("Inventory Id is already inserted!");
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
            BindData();
        }
        private void BindData()
        {
            ConnectionAPI api = new ConnectionAPI();
            List<tbl_inventory> lst_tbl = new List<tbl_inventory>();
            try
            {
                lst_tbl = api.GetContent("inventory").ReadAsAsync<List<tbl_inventory>>().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message);
            }
            dataGridView1.DataSource = new BindingSource(lst_tbl, "");
        }

        private void frm_inventory_control_1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id_barang.Text) && !string.IsNullOrEmpty(txt_nama_barang.Text) && !string.IsNullOrEmpty(txt_jumlah.Text) && int.TryParse(txt_jumlah.Text, out _))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("inventory?id_check=" + txt_id_barang.Text).ReadAsAsync<bool>().Result == true)
                    {
                        tbl_inventory tbl = new tbl_inventory
                        {
                            id_barang = txt_id_barang.Text,
                            nama_barang = txt_nama_barang.Text,
                            jumlah = Convert.ToInt32(txt_jumlah.Text),
                            create_date = DateTime.Now
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
            BindData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id_barang.Text, out _) && !string.IsNullOrEmpty(txt_id_barang.Text))
            {
                if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnectionAPI api = new ConnectionAPI();
                    try
                    {
                        if (api.GetContent("inventory?id_check=" + txt_id_barang.Text).ReadAsAsync<bool>().Result == true)
                        {
                            api.DeleteResponse("inventory?id=" + txt_id_barang.Text);
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
            BindData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            tbl_inventory tbl = new tbl_inventory();
            if (int.TryParse(txt_id_barang.Text, out _) && !string.IsNullOrEmpty(txt_id_barang.Text))
            {
                ConnectionAPI api = new ConnectionAPI();
                try
                {
                    if (api.GetContent("inventory?id_check=" + txt_id_barang.Text).ReadAsAsync<bool>().Result == true)
                    {
                        tbl = api.GetContent("inventory?id=" + txt_id_barang.Text).ReadAsAsync<tbl_inventory>().Result;
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
            else
            {
                MessageBox.Show("Put Number ID!");
            }
            dataGridView1.DataSource = new BindingSource(tbl, "");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            frm_inventory_control_list frm4 = new frm_inventory_control_list();
            frm4.Show();
        }

        #region backup
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-T8TD1G5E\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");
        //private void btn_insert_Click(object sender, EventArgs e)
        //{
        //    conn.Open();
        //    SqlCommand command = new SqlCommand("insert into inventroy values ('"+int.Parse(txt_id_barang.Text)+"','"+txt_nama_barang.Text+"','"+ int.Parse(txt_jumlah.Text)+ "', sysdatetimeoffset())", conn);
        //    command.ExecuteNonQuery();
        //    MessageBox.Show("Successfully Inserted!");
        //    conn.Close();
        //    BindData();
        //}
        //private void BindData()
        //{
        //    SqlCommand command = new SqlCommand("select * from inventroy", conn);
        //    //SqlCommand command = new SqlCommand("EXEC InsertData @NumberID ", con);
        //    SqlDataAdapter sd = new SqlDataAdapter(command);
        //    DataTable dt = new DataTable();
        //    sd.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}

        //private void frm_inventory_control_1_Load(object sender, EventArgs e)
        //{
        //    BindData();
        //}

        //private void btn_update_Click(object sender, EventArgs e)
        //{
        //    conn.Open();
        //    SqlCommand command = new SqlCommand("update inventroy set ID_Barang = '" + int.Parse(txt_id_barang.Text) + "',Nama_Barang = '" + txt_nama_barang.Text + "', Jumlah = '" + int.Parse(txt_jumlah.Text) + "', InsertDate = sysdatetimeoffset() where ID_Barang = '" + int.Parse(txt_id_barang.Text)+"'", conn);
        //    command.ExecuteNonQuery();
        //    conn.Close();
        //    MessageBox.Show("Successfully Updated!");
        //    BindData();
        //}

        //private void btn_delete_Click(object sender, EventArgs e)
        //{
        //    if (txt_id_barang.Text != "")
        //    {
        //        if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            conn.Open();
        //            SqlCommand command = new SqlCommand("Delete inventroy where ID_Barang= '" + int.Parse(txt_id_barang.Text) + "'", conn);
        //            command.ExecuteNonQuery();
        //            conn.Close();
        //            MessageBox.Show("Successfully Deleted!");
        //            BindData();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Put Number ID!");
        //    }
        //}

        //private void btn_search_Click(object sender, EventArgs e)
        //{
        //    SqlCommand command = new SqlCommand("select * from inventroy where ID_Barang = '" + int.Parse(txt_id_barang.Text)+"'", conn);
        //    SqlDataAdapter sd = new SqlDataAdapter(command);
        //    DataTable dt = new DataTable();
        //    sd.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //}

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    frm_inventory_control_list frm4 = new frm_inventory_control_list();
        //    frm4.Show();
        //}
        #endregion

    }
}
