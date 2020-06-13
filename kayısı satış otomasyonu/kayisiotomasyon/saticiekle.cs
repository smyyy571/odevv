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
    public partial class saticiekle : Form
    {
        public saticiekle()
        {
            InitializeComponent();
        }

        private void btn_YoneticiSayfasi_Click(object sender, EventArgs e)
        {
            yoneticisayfasi y = new yoneticisayfasi();
            this.Hide();
            y.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("Server=FUR-KAN; Database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        
        private void btn_Satici_Ekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Insert Into satici(ad, soyad, adres, tel_no, tc_kimlik) values('" + txt_Adi.Text + "', '" + txt_soyadi.Text + "', '" + txt_Adresi.Text + "', '" + txt_tel_No.Text + "', '" + txt_tc_no.Text + "')", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satıcı eklenmiştir");
        }
    }
}
