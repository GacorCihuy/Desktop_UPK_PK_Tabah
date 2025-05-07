namespace upk_pk_tabah
{
    partial class tambahKategori
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
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.judul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "KATEGORI";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(28, 68);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(256, 20);
            this.maskedTextBox1.TabIndex = 62;
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.judul.ForeColor = System.Drawing.Color.Green;
            this.judul.Location = new System.Drawing.Point(24, 15);
            this.judul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(152, 20);
            this.judul.TabIndex = 59;
            this.judul.Text = "TAMBAH KATEGORI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 20);
            this.panel1.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(28, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 64;
            this.button2.Text = "UPLOAD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.panel1);
            this.Name = "tambahKategori";
            this.Size = new System.Drawing.Size(746, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}
