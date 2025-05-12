using System;
using System.Windows.Forms;

namespace upk_pk_tabah
{
    static class AppEntry // Atau 'Program' jika Anda memilih nama file Program.cs
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // GANTI 'Login' DENGAN NAMA FORM UTAMA ANDA JIKA BERBEDA
            // Berdasarkan Solution Explorer Anda, sepertinya 'Login.cs' adalah form awal.
            Application.Run(new Login());
        }
    }
}