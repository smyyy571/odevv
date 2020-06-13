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
    public partial class üyeol : Form
    {
        public üyeol()
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
        private void btn_UyeOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new SqlCommand("INSERT INTO uyeol(isim,soyisim,adres,telefon_numarasi,iban_numarasi,parola) VALUES('" + txt_İsim.Text + "', '" + txt_Soyisim.Text + "','" + txt_Adres.Text + "', '" + txt_tel_no.Text + "','" + txt_iban.Text + "','" + txt_Parola.Text + "')",  baglanti);
            cmd.ExecuteReader();
            baglanti.Close();
            MessageBox.Show("Üye Olundu.");
        }

        private void üyeol_Load(object sender, EventArgs e)
        {
           
        }
    }
}
