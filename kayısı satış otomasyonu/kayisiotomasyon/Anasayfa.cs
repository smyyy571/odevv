using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kayisiotomasyon
{
    

    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public static int fiyat = 0;

        private void btn_YoneticiGiris_Click(object sender, EventArgs e)
        {
            yoneicigiris y = new yoneicigiris();
            this.Hide();
            y.ShowDialog();
        }

        private void btn_UyeOl_Click(object sender, EventArgs e)
        {
            üyeol u = new üyeol();
            this.Hide();
            u.ShowDialog();
        }

        private void btn_SaticiGiris_Click(object sender, EventArgs e)
        {
            saticigiris s = new saticigiris();
            this.Hide();
            s.ShowDialog();
        }
        public static string gecis;
        SqlConnection baglanti = new SqlConnection("server=FUR-KAN; Database=kayisi; Trusted_Connection=true");

        private void btn_YasKayisi_Click(object sender, EventArgs e)
        {
            fiyat = 15;
            gecis = "YasKayisi";
            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeol where isim='" + üyegiris.ad + "' and parola='" + üyegiris.sifre + "' ", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayisibilgi k = new kayisibilgi();
                this.Hide();
                k.Show();
            }
            else
            {
                MessageBox.Show("Lütfen üye girişi yapınız");
            }
            baglanti.Close();
        }

        private void btn_KuruKayisi_Click(object sender, EventArgs e)
        {
            fiyat = 25;

            gecis = "KuruKayisi";
            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeol where isim='" + üyegiris.ad + "' and parola='" + üyegiris.sifre + "' ", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayisibilgi k = new kayisibilgi();
                this.Hide();
                k.ShowDialog();

            }
            else
            {
                MessageBox.Show("Lütfen üye girişi yapınız");
            }
            baglanti.Close();

        }
        private void btn_GünKurusuKayisi_Click(object sender, EventArgs e)
        {
            fiyat = 50;
            gecis = "GunKurusu";
            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeol where isim='" + üyegiris.ad + "' and parola='" + üyegiris.sifre + "' ", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayisibilgi k = new kayisibilgi();
                this.Hide();
                k.ShowDialog();

            }
            else
            {
                MessageBox.Show("Lütfen üye girişi yapınız");
            }
            baglanti.Close();
           
        
        }

        private void btn_KayisiCekirdegi_Click(object sender, EventArgs e)
        {
            fiyat = 30;
            gecis = "KayisiCekirdegi";
            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeol where isim='" + üyegiris.ad + "' and parola='" + üyegiris.sifre + "' ", baglanti);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kayisibilgi k = new kayisibilgi();
                this.Hide();
                k.ShowDialog();

            }
            else
            {
                MessageBox.Show("Lütfen üye girişi yapınız");
            }
            baglanti.Close();
        }

        private void btn_UyeGiris_Click(object sender, EventArgs e)
        {
            üyegiris u = new üyegiris();
            this.Hide();
            u.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
