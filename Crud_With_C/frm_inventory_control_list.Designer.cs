
namespace Crud_With_C
{
    partial class frm_inventory_control_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gudang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_loading = new System.Windows.Forms.Label();
            this.lb_id_gudang = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataIndexGudang = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nama_gudang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndexGudang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gudang
            // 
            this.btn_gudang.BackColor = System.Drawing.Color.Teal;
            this.btn_gudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gudang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gudang.Location = new System.Drawing.Point(472, 131);
            this.btn_gudang.Name = "btn_gudang";
            this.btn_gudang.Size = new System.Drawing.Size(161, 49);
            this.btn_gudang.TabIndex = 41;
            this.btn_gudang.Text = "Go to Inventory";
            this.btn_gudang.UseVisualStyleBackColor = false;
            this.btn_gudang.Click += new System.EventHandler(this.btn_gudang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 54);
            this.label1.TabIndex = 36;
            this.label1.Text = "Inventory Control List";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logout.Location = new System.Drawing.Point(681, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(82, 31);
            this.btn_logout.TabIndex = 45;
            this.btn_logout.Text = "Log-Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_loading.ForeColor = System.Drawing.Color.White;
            this.lb_loading.Location = new System.Drawing.Point(33, 221);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(0, 20);
            this.lb_loading.TabIndex = 62;
            // 
            // lb_id_gudang
            // 
            this.lb_id_gudang.AutoSize = true;
            this.lb_id_gudang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_id_gudang.ForeColor = System.Drawing.Color.White;
            this.lb_id_gudang.Location = new System.Drawing.Point(161, 102);
            this.lb_id_gudang.Name = "lb_id_gudang";
            this.lb_id_gudang.Size = new System.Drawing.Size(0, 20);
            this.lb_id_gudang.TabIndex = 61;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(431, 223);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(241, 20);
            this.txt_search.TabIndex = 60;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(165, 186);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(241, 20);
            this.txt_alamat.TabIndex = 59;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Teal;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Location = new System.Drawing.Point(678, 217);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 31);
            this.btn_search.TabIndex = 58;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(338, 217);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 31);
            this.btn_delete.TabIndex = 57;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(262, 217);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(70, 31);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataIndexGudang
            // 
            this.dataIndexGudang.AllowUserToAddRows = false;
            this.dataIndexGudang.AllowUserToDeleteRows = false;
            this.dataIndexGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIndexGudang.Location = new System.Drawing.Point(37, 254);
            this.dataIndexGudang.Name = "dataIndexGudang";
            this.dataIndexGudang.RowHeadersWidth = 62;
            this.dataIndexGudang.Size = new System.Drawing.Size(705, 248);
            this.dataIndexGudang.TabIndex = 55;
            this.dataIndexGudang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIndexGudang_CellDoubleClick);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Teal;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_insert.Location = new System.Drawing.Point(198, 217);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(58, 31);
            this.btn_insert.TabIndex = 54;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Alamat";
            // 
            // txt_nama_gudang
            // 
            this.txt_nama_gudang.Location = new System.Drawing.Point(165, 146);
            this.txt_nama_gudang.Name = "txt_nama_gudang";
            this.txt_nama_gudang.Size = new System.Drawing.Size(241, 20);
            this.txt_nama_gudang.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nama Gudang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID Gudang";
            // 
            // frm_inventory_control_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(775, 534);
            this.Controls.Add(this.lb_loading);
            this.Controls.Add(this.lb_id_gudang);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataIndexGudang);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nama_gudang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_gudang);
            this.Controls.Add(this.label1);
            this.Name = "frm_inventory_control_list";
            this.Text = "Inventory Control List";
            this.Load += new System.EventHandler(this.frm_inventory_control_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataIndexGudang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gudang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_loading;
        private System.Windows.Forms.Label lb_id_gudang;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataIndexGudang;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nama_gudang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}