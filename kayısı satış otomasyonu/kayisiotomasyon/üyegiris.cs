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
    public partial class üyegiris : Form
    {
        public üyegiris()
        {
            InitializeComponent();
        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("server=FUR-KAN; Database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public static string ad;
        public static string sifre;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM uyeol where isim='" + txt_ad.Text + "'and  soyisim='" + txt_soyisim.Text + "' and parola='"+txt_parola.Text+"' ", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ad = txt_ad.Text;
                sifre = txt_parola.Text;
                Anasayfa y = new Anasayfa();
                this.Hide();
                y.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır");
            }
            baglanti.Close();
        }

        private void üyegiris_Load(object sender, EventArgs e)
        {

        }
    }
}
