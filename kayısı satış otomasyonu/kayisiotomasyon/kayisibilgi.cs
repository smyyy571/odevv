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
    public partial class kayisibilgi : Form
    {
        public kayisibilgi()
        {
            InitializeComponent();
        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.ShowDialog();

            Anasayfa.gecis = "";
        }

        SqlConnection baglanti = new SqlConnection("server=FUR-KAN; database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        SqlDataReader dr;
        private void kayisibilgi_Load(object sender, EventArgs e)
        {
            Anasayfa ana=new Anasayfa();
            if (Anasayfa.gecis=="YasKayisi")
            {
                cmd = new SqlCommand("Select yaskayisistok from stok ", baglanti);
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();
            }
            else if (Anasayfa.gecis == "KuruKayisi")
            {
                cmd = new SqlCommand("Select kurkayisistok from stok ", baglanti);
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();
            }
            else if (Anasayfa.gecis == "GunKurusu")
            {
                cmd = new SqlCommand("Select günkurusukayisistok from stok ", baglanti);
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();
            }
            else if (Anasayfa.gecis == "KayisiCekirdegi")
            {
                cmd = new SqlCommand("Select kayisicekirdegistok from stok ", baglanti);
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                    MessageBox.Show(dr[0].ToString());
                }
                baglanti.Close();
            }
            lbl_fiyat7.Text = "";

        }
        public int fiyat = 0;
        private void btn_SatinAl_Click(object sender, EventArgs e)
        {
            
            
            if (Anasayfa.gecis == "YasKayisi")
            {
                fiyat = 15 * Convert.ToInt32(txt_miktar.Text);
                lbl_fiyat7.Text = fiyat.ToString();
                cmd = new SqlCommand("Insert Into satislar(miktar, iban, adres, kayisi, fiyat) values ('" + txt_miktar.Text + "', '" + txt_iban.Text + "','" + txt_adres.Text + "', '" + Anasayfa.gecis + "', '" + fiyat.ToString() + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla tamamlanmıştır");
                baglanti.Close();
                int a = (Convert.ToInt32(lbl_StokDurumu.Text) - Convert.ToInt32(txt_miktar.Text));
                cmd = new SqlCommand("UPDATE stok set yaskayisistok='" + a + "'", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select yaskayisistok from stok", baglanti);
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                
                baglanti.Close();
            }
            else if (Anasayfa.gecis == "KuruKayisi")
            {

                fiyat = 25 * Convert.ToInt32(txt_miktar.Text);
                lbl_fiyat7.Text = fiyat.ToString();
                cmd = new SqlCommand("Insert Into satislar(miktar, iban, adres, kayisi, fiyat) values ('" + txt_miktar.Text + "', '" + txt_iban.Text + "','" + txt_adres.Text + "', '" + Anasayfa.gecis + "', '" + fiyat.ToString() + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla tamamlanmıştır");
                baglanti.Close();
                int a = (Convert.ToInt32(lbl_StokDurumu.Text) - Convert.ToInt32(txt_miktar.Text));
                cmd = new SqlCommand("UPDATE stok set kurukayisistok='" + a + "'", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select kurukayisistok from stok", baglanti);
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();
            }
            else if (Anasayfa.gecis == "GunKurusu")
            {

                fiyat = 50 * Convert.ToInt32(txt_miktar.Text);
                lbl_fiyat7.Text = fiyat.ToString();
                cmd = new SqlCommand("Insert Into satislar(miktar, iban, adres, kayisi, fiyat) values ('" + txt_miktar.Text + "', '" + txt_iban.Text + "','" + txt_adres.Text + "', '" + Anasayfa.gecis + "', '" + fiyat.ToString() + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla tamamlanmıştır");
                baglanti.Close();
                int a = (Convert.ToInt32(lbl_StokDurumu.Text) - Convert.ToInt32(txt_miktar.Text));
                cmd = new SqlCommand("UPDATE stok set günkurusukayisistok='" + a + "'", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select günkurusukayisistok from stok", baglanti);
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();

            }
            else if (Anasayfa.gecis == "KayisiCekirdegi")
            {

                fiyat = 30 * Convert.ToInt32(txt_miktar.Text);
                lbl_fiyat7.Text = fiyat.ToString();
                cmd = new SqlCommand("Insert Into satislar(miktar, iban, adres, kayisi, fiyat) values ('" + txt_miktar.Text + "', '" + txt_iban.Text + "','" + txt_adres.Text + "', '" + Anasayfa.gecis + "', '" + fiyat.ToString() + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Satış başarıyla tamamlanmıştır");
                baglanti.Close();
                int a = (Convert.ToInt32(lbl_StokDurumu.Text) - Convert.ToInt32(txt_miktar.Text));
                cmd = new SqlCommand("UPDATE stok set kayisicekirdegistok='" + a + "'", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("select kayisicekirdegistok from stok", baglanti);
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    lbl_StokDurumu.Text = Convert.ToInt32(dr[0]).ToString();
                }
                baglanti.Close();

            }
        }
    }
}
