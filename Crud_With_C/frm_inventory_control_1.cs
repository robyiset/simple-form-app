using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_With_C
{
    public partial class frm_inventory_control_1 : Form
    {
        public frm_inventory_control_1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-T8TD1G5E\SQLEXPRESS01;Initial Catalog=Inventory;Integrated Security=True");
        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("insert into inventroy values ('"+int.Parse(txt_id_barang.Text)+"','"+txt_nama_barang.Text+"','"+ int.Parse(txt_jumlah.Text)+ "', sysdatetimeoffset())", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted!");
            conn.Close();
            BindData();
        }
        private void BindData()
        {
            SqlCommand command = new SqlCommand("select * from inventroy", conn);
            //SqlCommand command = new SqlCommand("EXEC InsertData @NumberID ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("update inventroy set ID_Barang = '" + int.Parse(txt_id_barang.Text) + "',Nama_Barang = '" + txt_nama_barang.Text + "', Jumlah = '" + int.Parse(txt_jumlah.Text) + "', InsertDate = sysdatetimeoffset() where ID_Barang = '" + int.Parse(txt_id_barang.Text)+"'", conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated!");
            BindData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id_barang.Text != "")
            {
                if (MessageBox.Show("Confirm Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Delete inventroy where ID_Barang= '" + int.Parse(txt_id_barang.Text) + "'", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Deleted!");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put Number ID!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from inventroy where ID_Barang = '" + int.Parse(txt_id_barang.Text)+"'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            frm_inventory_control_list frm4 = new frm_inventory_control_list();
            frm4.Show();
        }
    }
}
