using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayisiotomasyon
{
    public partial class saticigiris : Form
    {
        public saticigiris()
        {
            InitializeComponent();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();
            this.Hide();
            a.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("server=FUR-KAN; Database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        SqlDataReader dr;
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM satici where tc_kimlik='" + txt_tc_no.Text + "'and  ad='" + txt_ad.Text + "'", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                saticisayfası y = new saticisayfası();
                this.Hide();
                y.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da tc hatalıdır");
            }
            baglanti.Close();
        }
    }
}
