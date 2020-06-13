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
    public partial class yoneicigiris : Form
    {
        public yoneicigiris()
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

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM yonetici where yoneticiad='" + txt_KullaniciAdi.Text + "'and  sifre='" + txt_Parola.Text + "' ", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yoneticisayfasi y = new yoneticisayfasi();
                this.Hide();
                y.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifreniz hatalıdır");
            }
            baglanti.Close();
        }
    }
}
