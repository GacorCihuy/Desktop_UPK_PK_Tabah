using System.Windows.Forms;
using System;

namespace upk_pk_tabah
{
    public partial class Dashboard : Form
    {
        // Asumsi semua field UserControl (beranda1, berita1, kategori1, tambahKategori1, tambahBerita1, dll.)
        // dideklarasikan di Dashboard.Designer.cs dan diinisialisasi oleh InitializeComponent().

        public Dashboard()
        {
            InitializeComponent();

            // Subscribe ke event dari kategori1
            if (this.kategori1 != null)
            {
                this.kategori1.TambahKategoriButtonClicked += Kategori1_TambahKategoriButtonClicked;
            }
            else
            {
                MessageBox.Show("Peringatan: Kontrol 'kategori1' tidak ditemukan.", "Inisialisasi Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Subscribe ke event dari berita1
            if (this.berita1 != null)
            {
                this.berita1.TambahBeritaButtonClicked += Berita1_TambahBeritaButtonClicked;
            }
            else
            {
                MessageBox.Show("Peringatan: Kontrol 'berita1' tidak ditemukan.", "Inisialisasi Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Pastikan instance untuk tambahBerita1 sudah ada jika berbeda dari tambahKategori1
            // Jika tambahBerita1 dan tambahKategori1 adalah instance UserControl yang sama (misal, dari UserControl generik 'FormInput.cs'),
            // maka tidak perlu inisialisasi tambahan.
            // Jika berbeda, pastikan 'tambahBerita1' (atau nama instance yang Anda gunakan) sudah diinisialisasi di Desainer.
            // Contoh: if (this.tambahBerita1 == null) { /* Handle error atau inisialisasi */ }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Tampilkan UserControl default saat form dimuat, misalnya beranda1
            if (this.beranda1 != null)
            {
                this.beranda1.BringToFront();
                // Jika Anda mengelola Visible secara manual:
                // SembunyikanSemuaKecuali(this.beranda1);
                // this.beranda1.Visible = true;
            }
            // Jika tidak ada beranda, mungkin kategori atau berita sebagai default
            // else if (this.berita1 != null)
            // {
            //    this.berita1.BringToFront();
            // }
        }

        // --- Event Handler Navigasi Utama (Struktur Asli Anda) ---
        private void bBeranda_Click(object sender, EventArgs e)
        {
            if (this.beranda1 != null) this.beranda1.BringToFront();
        }

        private void bBerita_Click(object sender, EventArgs e)
        {
            if (this.berita1 != null) this.berita1.BringToFront();
        }

        private void bProgram_Click(object sender, EventArgs e)
        {
            if (this.program1 != null) this.program1.BringToFront();
        }

        private void bPrestasi_Click(object sender, EventArgs e)
        {
            if (this.prestasi1 != null) this.prestasi1.BringToFront();
        }

        private void bEkskul_Click(object sender, EventArgs e)
        {
            if (this.ekstrakulikuler1 != null) this.ekstrakulikuler1.BringToFront();
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            if (this.aboutus1 != null) this.aboutus1.BringToFront();
        }

        private void bKontak_Click(object sender, EventArgs e)
        {
            if (this.kontak1 != null) this.kontak1.BringToFront();
        }

        private void bPpdb_Click(object sender, EventArgs e)
        {
            if (this.ppdb1 != null) this.ppdb1.BringToFront();
        }

        private void bHadist_Click(object sender, EventArgs e)
        {
            if (this.hadist1 != null) this.hadist1.BringToFront();
        }

        private void bAlumni_Click(object sender, EventArgs e)
        {
            if (this.alumni1 != null) this.alumni1.BringToFront();
        }

        private void bKategori_Click(object sender, EventArgs e)
        {
            if (this.kategori1 != null) this.kategori1.BringToFront();
        }

        // --- Event Handler untuk Aksi dari UserControl ---

        // Handler untuk event dari kategori1 (Tambah Kategori)
        private void Kategori1_TambahKategoriButtonClicked(object sender, EventArgs e)
        {
            // 'tambahKategori1' adalah nama instance UserControl tambahKategori Anda
            if (this.tambahKategori1 != null)
            {
                // Jika Anda ingin menyembunyikan kategori1 secara eksplisit:
                // if (this.kategori1 != null) this.kategori1.Visible = false;
                // this.tambahKategori1.Visible = true; // Pastikan target visible
                this.tambahKategori1.BringToFront();
            }
            else
            {
                MessageBox.Show("Peringatan: Kontrol 'tambahKategori1' tidak ditemukan.", "Operasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Handler untuk event dari berita1 (Tambah Berita)
        private void Berita1_TambahBeritaButtonClicked(object sender, EventArgs e)
        {
            // 'tambahBerita1' adalah nama instance UserControl tambahBerita Anda.
            // Ini bisa jadi instance yang sama dengan 'tambahKategori1' jika desainnya generik,
            // atau instance yang berbeda jika formnya spesifik untuk berita.
            if (this.tambahBerita1 != null)
            {
                // Jika Anda ingin menyembunyikan berita1 secara eksplisit:
                // if (this.berita1 != null) this.berita1.Visible = false;
                // this.tambahBerita1.Visible = true; // Pastikan target visible
                this.tambahBerita1.BringToFront();
                // Anda mungkin ingin memanggil method di 'tambahBerita1' untuk mengkonfigurasinya
                // untuk mode "tambah berita", misalnya:
                // if (this.tambahBerita1 is UserControlInputGenerik ucGenerik)
                // {
                //    ucGenerik.SetMode("Berita");
                // }
            }
            else
            {
                MessageBox.Show("Peringatan: Kontrol 'tambahBerita1' tidak ditemukan.", "Operasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- Tombol Logout ---
        private void bLogout_Click(object sender, EventArgs e)
        {
            Login window = new Login();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }


        // --- Event Handler Lain yang Sudah Ada di Kode Anda ---
        // Biarkan apa adanya jika tidak ada perubahan yang diperlukan.
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void search_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { } // Pastikan ini terhubung jika ada logika
        private void gradientPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox7_Click(object sender, EventArgs e) { }
        private void berita1_Load(object sender, EventArgs e) { }
        private void aboutus1_Load(object sender, EventArgs e) { }
        private void pSearch_Paint(object sender, PaintEventArgs e) { }
        private void pictureBoxSearch_Click(object sender, EventArgs e) { }
        private void beranda1_Load(object sender, EventArgs e) { }
    }
}