﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upk_pk_tabah
{
    public partial class kategori : UserControl
    {
      
        public event EventHandler TambahKategoriButtonClicked;

        public kategori()
        {
            InitializeComponent();
        }

        
        private void bTambah_Click(object sender, EventArgs e)
        {
            // Memicu event
            OnTambahKategoriButtonClicked();
        }

        
        protected virtual void OnTambahKategoriButtonClicked()
        {
            TambahKategoriButtonClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
