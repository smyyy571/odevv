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
    public partial class Saticisil : Form
    {
        public Saticisil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yoneticisayfasi y = new yoneticisayfasi();
            this.Hide();
            y.ShowDialog();
        }
        SqlConnection baglanti = new SqlConnection("Server=FUR-KAN; Database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        SqlDataReader dr;
        private void btn_Satici_Sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from satici where tc_kimlik='" + cmb_SaticiSec.Text + "'", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DialogResult a = new DialogResult();
                a=MessageBox.Show(dr["ad"].ToString() + " " + dr["soyad".ToString()]+ " adlı satıcıyı silmek istediğinize emin misiniz","",MessageBoxButtons.OKCancel);
                if (a==DialogResult.OK)
                {
                    dr.Close();
                    SqlCommand cmd2 = new SqlCommand("delete  from satici where tc_kimlik='" + cmb_SaticiSec.Text + "'", baglanti);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Silme işleminiz gerçekleştirilmiştir");
                }
                else
                {
                    MessageBox.Show("Silme işleminizi iptal ettiniz");
                }
            }
            baglanti.Close();
        }

        private void Saticisil_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select tc_kimlik from satici",baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_SaticiSec.Items.Add (dr[0].ToString());
            }
            baglanti.Close();
        }
    }
}
