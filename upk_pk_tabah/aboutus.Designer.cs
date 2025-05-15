namespace upk_pk_tabah
{
    partial class aboutus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bTambah = new System.Windows.Forms.Button();
            this.judul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bTambah
            // 
            this.bTambah.BackColor = System.Drawing.Color.Gold;
            this.bTambah.FlatAppearance.BorderSize = 0;
            this.bTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTambah.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bTambah.ForeColor = System.Drawing.Color.White;
            this.bTambah.Location = new System.Drawing.Point(48, 69);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(114, 32);
            this.bTambah.TabIndex = 21;
            this.bTambah.Text = "EDIT";
            this.bTambah.UseVisualStyleBackColor = false;
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.judul.ForeColor = System.Drawing.Color.Green;
            this.judul.Location = new System.Drawing.Point(43, 28);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(208, 25);
            this.judul.TabIndex = 20;
            this.judul.Text = "HALAMAN ABOUT US";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(26, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 25);
            this.panel1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(917, 398);
            this.dataGridView1.TabIndex = 22;
            // 
            // aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.panel1);
            this.Name = "aboutus";
            this.Size = new System.Drawing.Size(998, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTambah;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
