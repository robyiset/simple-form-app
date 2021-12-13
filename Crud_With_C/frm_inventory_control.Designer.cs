
namespace Crud_With_C
{
    partial class frm_inventory_control
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
            this.lb_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama_barang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dataGridBarang = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_jumlah = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lb_id_barang = new System.Windows.Forms.Label();
            this.lb_loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Segoe Print", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(24, 12);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(0, 54);
            this.lb_title.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Barang";
            // 
            // txt_nama_barang
            // 
            this.txt_nama_barang.Location = new System.Drawing.Point(161, 145);
            this.txt_nama_barang.Name = "txt_nama_barang";
            this.txt_nama_barang.Size = new System.Drawing.Size(241, 20);
            this.txt_nama_barang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jumlah";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.Teal;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_insert.Location = new System.Drawing.Point(194, 216);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(58, 31);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dataGridBarang
            // 
            this.dataGridBarang.AllowUserToAddRows = false;
            this.dataGridBarang.AllowUserToDeleteRows = false;
            this.dataGridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBarang.Location = new System.Drawing.Point(33, 253);
            this.dataGridBarang.Name = "dataGridBarang";
            this.dataGridBarang.RowHeadersWidth = 62;
            this.dataGridBarang.Size = new System.Drawing.Size(705, 248);
            this.dataGridBarang.TabIndex = 8;
            this.dataGridBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBarang_CellDoubleClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(258, 216);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(70, 31);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(334, 216);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 31);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Teal;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.Location = new System.Drawing.Point(674, 216);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 31);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_jumlah
            // 
            this.txt_jumlah.Location = new System.Drawing.Point(161, 185);
            this.txt_jumlah.Name = "txt_jumlah";
            this.txt_jumlah.Size = new System.Drawing.Size(241, 20);
            this.txt_jumlah.TabIndex = 12;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_back.Location = new System.Drawing.Point(701, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(62, 31);
            this.btn_back.TabIndex = 46;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(427, 222);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(241, 20);
            this.txt_search.TabIndex = 47;
            // 
            // lb_id_barang
            // 
            this.lb_id_barang.AutoSize = true;
            this.lb_id_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_id_barang.ForeColor = System.Drawing.Color.White;
            this.lb_id_barang.Location = new System.Drawing.Point(157, 101);
            this.lb_id_barang.Name = "lb_id_barang";
            this.lb_id_barang.Size = new System.Drawing.Size(0, 20);
            this.lb_id_barang.TabIndex = 48;
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb_loading.ForeColor = System.Drawing.Color.White;
            this.lb_loading.Location = new System.Drawing.Point(423, 145);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(0, 20);
            this.lb_loading.TabIndex = 49;
            // 
            // frm_inventory_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(775, 534);
            this.Controls.Add(this.lb_loading);
            this.Controls.Add(this.lb_id_barang);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_jumlah);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridBarang);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nama_barang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_title);
            this.Name = "frm_inventory_control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control #1";
            this.Load += new System.EventHandler(this.frm_inventory_control_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama_barang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dataGridBarang;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_jumlah;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lb_id_barang;
        private System.Windows.Forms.Label lb_loading;
    }
}

