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

namespace sinematik
{
    public partial class FrmFilmDetay : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        public string idNo = "";
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_Filmler Where ID=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pBResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdi.Text = oku["ADI"].ToString();
                lblBicim.Text = DistinctValues(oku["BICIMI"].ToString());
                lblOzellik.Text = DistinctValues(oku["OZELLIKLERI"].ToString());
                lblTur.Text = DistinctValues(oku["TURU"].ToString());
                lblOyuncu.Text = oku["OYUNCU"].ToString();
                lblYonetmen.Text = oku["YONETMEN"].ToString();
                lblVizyonTarihi.Text = oku["TARIH"].ToString();
                lblDurum.Text = oku["DURUM"].ToString();
                lblDetay.Text = oku["DETAY"].ToString();
                lblPuan.Text = oku["PUAN"].ToString();
            }
            baglanti.Close();
            if (lblDurum.Text == "0")
            {
                lblDurum.Text = "FİLM VİZYONDA!";
            }
            else
            {
                lblDurum.Text = "FİLM VİZYONA GİRMEDİ!";
            }
        }
        private string DistinctValues(string input)
        {
            var values = input.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var distinctValues = values.Distinct();
            return string.Join(", ", distinctValues);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
