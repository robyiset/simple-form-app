
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
            this.btn_gudang_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gudang_2 = new System.Windows.Forms.Button();
            this.btn_gudang_3 = new System.Windows.Forms.Button();
            this.btn_gudang_4 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gudang_1
            // 
            this.btn_gudang_1.BackColor = System.Drawing.Color.Teal;
            this.btn_gudang_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gudang_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gudang_1.Location = new System.Drawing.Point(219, 228);
            this.btn_gudang_1.Name = "btn_gudang_1";
            this.btn_gudang_1.Size = new System.Drawing.Size(161, 49);
            this.btn_gudang_1.TabIndex = 41;
            this.btn_gudang_1.Text = "Gudang #1";
            this.btn_gudang_1.UseVisualStyleBackColor = false;
            this.btn_gudang_1.Click += new System.EventHandler(this.btn_gudang_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 54);
            this.label1.TabIndex = 36;
            this.label1.Text = "Inventory Control List";
            // 
            // btn_gudang_2
            // 
            this.btn_gudang_2.BackColor = System.Drawing.Color.Teal;
            this.btn_gudang_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gudang_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gudang_2.Location = new System.Drawing.Point(409, 228);
            this.btn_gudang_2.Name = "btn_gudang_2";
            this.btn_gudang_2.Size = new System.Drawing.Size(161, 49);
            this.btn_gudang_2.TabIndex = 42;
            this.btn_gudang_2.Text = "Gudang #2";
            this.btn_gudang_2.UseVisualStyleBackColor = false;
            this.btn_gudang_2.Click += new System.EventHandler(this.btn_gudang_2_Click);
            // 
            // btn_gudang_3
            // 
            this.btn_gudang_3.BackColor = System.Drawing.Color.Teal;
            this.btn_gudang_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gudang_3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gudang_3.Location = new System.Drawing.Point(219, 302);
            this.btn_gudang_3.Name = "btn_gudang_3";
            this.btn_gudang_3.Size = new System.Drawing.Size(161, 49);
            this.btn_gudang_3.TabIndex = 43;
            this.btn_gudang_3.Text = "Gudang #3";
            this.btn_gudang_3.UseVisualStyleBackColor = false;
            this.btn_gudang_3.Click += new System.EventHandler(this.btn_gudang_3_Click);
            // 
            // btn_gudang_4
            // 
            this.btn_gudang_4.BackColor = System.Drawing.Color.Teal;
            this.btn_gudang_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_gudang_4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_gudang_4.Location = new System.Drawing.Point(409, 302);
            this.btn_gudang_4.Name = "btn_gudang_4";
            this.btn_gudang_4.Size = new System.Drawing.Size(161, 49);
            this.btn_gudang_4.TabIndex = 44;
            this.btn_gudang_4.Text = "Gudang #4";
            this.btn_gudang_4.UseVisualStyleBackColor = false;
            this.btn_gudang_4.Click += new System.EventHandler(this.btn_gudang_4_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logout.Location = new System.Drawing.Point(681, 491);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(82, 31);
            this.btn_logout.TabIndex = 45;
            this.btn_logout.Text = "Log-Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // frm_inventory_control_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(775, 534);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_gudang_4);
            this.Controls.Add(this.btn_gudang_3);
            this.Controls.Add(this.btn_gudang_2);
            this.Controls.Add(this.btn_gudang_1);
            this.Controls.Add(this.label1);
            this.Name = "frm_inventory_control_list";
            this.Text = "Inventory Control List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gudang_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_gudang_2;
        private System.Windows.Forms.Button btn_gudang_3;
        private System.Windows.Forms.Button btn_gudang_4;
        private System.Windows.Forms.Button btn_logout;
    }
}