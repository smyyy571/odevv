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
    public partial class saticisayfası : Form
    {
        public saticisayfası()
        {
            InitializeComponent();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.ShowDialog();
        }

        private void btn_Müsteriler_Click(object sender, EventArgs e)
        {
            musteriler m = new musteriler();
            this.Hide();
            m.Show();
        }

        private void btn_Satis_Durumu_Click(object sender, EventArgs e)
        {
            satisdurum s = new satisdurum();
            this.Hide();
            s.Show();
        }
    }
}
