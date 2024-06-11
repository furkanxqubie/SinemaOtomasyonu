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
    public partial class YonetmenListesi : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        private void btnDetay_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("BİYOGRAFİ : " + oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler WHERE ID =@p1",baglanti);
            sil.Parameters.AddWithValue("@p1",lblId.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            this.Hide();
            MessageBox.Show(lblAdSoyad.Text + " Kişisine ait kayıt başarılı bir şekilde silinmiştir!");
        }

        private void YonetmenListesi_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            baglanti.Close();
        }
    }
}
