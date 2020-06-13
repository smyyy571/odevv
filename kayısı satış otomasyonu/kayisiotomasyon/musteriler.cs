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
    public partial class musteriler : Form
    {
        public musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=FUR-KAN; Database=kayisi; Trusted_Connection=true");
        SqlCommand cmd;
        private void musteriler_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from uyeol", baglanti);
            baglanti.Open();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable ds = new  DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saticisayfası s = new saticisayfası();
            this.Hide();
            s.Show();
        }
    }
}
