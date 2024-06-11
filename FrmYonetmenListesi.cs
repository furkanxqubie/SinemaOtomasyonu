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

namespace sinematik
{
    public partial class FrmYonetmenListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();

            SqlCommand ara = new SqlCommand("select * from Tbl_Yonetmenler WHERE ADSOYAD LIKE '%"+txtAramaYap.Text+"%'",baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
