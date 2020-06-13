using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayisiotomasyon
{
    public partial class yoneticisayfasi : Form
    {
        public yoneticisayfasi()
        {
            InitializeComponent();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.ShowDialog();
        }

        private void btn_StokGüncelle_Click(object sender, EventArgs e)
        {
            stokgüncelle s = new stokgüncelle();
            this.Hide();
            s.Show();
        }

        private void btn_SaticiEkle_Click(object sender, EventArgs e)
        {
            saticiekle s = new saticiekle();
            this.Hide();
            s.Show();
        }

        private void btn_SaticiSil_Click(object sender, EventArgs e)
        {
            Saticisil s = new Saticisil();
            this.Hide();
            s.Show();
        }
    }
}
