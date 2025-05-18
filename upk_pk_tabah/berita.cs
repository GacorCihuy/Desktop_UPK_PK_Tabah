// berita.cs
using System;
using System.Windows.Forms;

namespace upk_pk_tabah
{
    public partial class berita : UserControl
    {
        // 1. Deklarasikan event
        public event EventHandler TambahBeritaButtonClicked;

        public berita()
        {
            InitializeComponent();
        }

        // Asumsi tombol di desainer berita.cs bernama 'bTambah'
        private void bTambah_Click(object sender, EventArgs e)
        {
            // 2. Picu event ketika tombol 'bTambah' diklik
            OnTambahBeritaButtonClicked();

            // HAPUS ATAU KOMENTARI KODE LAMA INI:
            // tambahBerita form =  new tambahBerita();
            // form.Show();
        }

        // Method helper untuk memicu event (praktik yang baik)
        protected virtual void OnTambahBeritaButtonClicked()
        {
            TambahBeritaButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        // Event handler lain yang sudah ada di berita.cs
        private void label2_Click(object sender, EventArgs e) { }
        private void judul_Click(object sender, EventArgs e) { }
        private void berita_Load(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { } // Pastikan fungsi tombol ini jika ada
    }
}