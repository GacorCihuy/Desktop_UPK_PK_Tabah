namespace upk_pk_tabah
{
    partial class ppdb
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
            this.SuspendLayout();
            // 
            // bTambah
            // 
            this.bTambah.BackColor = System.Drawing.Color.Chartreuse;
            this.bTambah.FlatAppearance.BorderSize = 0;
            this.bTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTambah.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bTambah.ForeColor = System.Drawing.Color.White;
            this.bTambah.Location = new System.Drawing.Point(38, 58);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(114, 32);
            this.bTambah.TabIndex = 10;
            this.bTambah.Text = "EDIT";
            this.bTambah.UseVisualStyleBackColor = false;
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.judul.ForeColor = System.Drawing.Color.Green;
            this.judul.Location = new System.Drawing.Point(33, 17);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(164, 25);
            this.judul.TabIndex = 9;
            this.judul.Text = "HALAMAN PPDB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 25);
            this.panel1.TabIndex = 8;
            // 
            // ppdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.panel1);
            this.Name = "ppdb";
            this.Size = new System.Drawing.Size(998, 577);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTambah;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Panel panel1;
    }
}
