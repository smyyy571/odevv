using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kayisiotomasyon
{
    public partial class stokgüncelle : Form
    {
        public stokgüncelle()
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
        SqlDataReader dr;
        public static int yaskayisi;
        public static int kurukayisi;
        public static int gunkurusu;
        public static int kayisicekirdegi;

        private void btn_StokGüncelle_Click(object sender, EventArgs e)
        {
             yaskayisi=Convert.ToInt32(lbl_yaskayisi.Text)+Convert.ToInt32(txt_yaskayisi.Text);
             kurukayisi=Convert.ToInt32(lbl_kurukayisi.Text)+Convert.ToInt32(txt_kurukayisi.Text);
             gunkurusu=Convert.ToInt32(lbl_günkurusukayisi.Text)+Convert.ToInt32(txt_günkurusukayisi.Text);
             kayisicekirdegi=Convert.ToInt32(lbl_kayisicekirdegi.Text)+Convert.ToInt32(txt_kayisicekirdegi.Text);
            cmd = new SqlCommand("UPDATE stok set yaskayisistok='" + yaskayisi + "', kurkayisistok='"+kurukayisi+"', günkurusukayisistok='"+gunkurusu+"', kayisicekirdegistok= '"+kayisicekirdegi+"'", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("select * from stok", baglanti);
            dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                lbl_yaskayisi.Text = dr["yaskayisistok"].ToString();
                lbl_kurukayisi.Text = dr["kurkayisistok"].ToString();
                lbl_günkurusukayisi.Text = dr["günkurusukayisistok"].ToString();
                lbl_kayisicekirdegi.Text = dr["kayisicekirdegistok"].ToString();

            }
            baglanti.Close();
        }

        private void stokgüncelle_Load(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select * from stok",baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_yaskayisi.Text = dr["yaskayisistok"].ToString();
                lbl_kurukayisi.Text = dr["kurkayisistok"].ToString();
                lbl_günkurusukayisi.Text = dr["günkurusukayisistok"].ToString();
                lbl_kayisicekirdegi.Text = dr["kayisicekirdegistok"].ToString();
              
            }
            baglanti.Close();
            
        }
    }
}
