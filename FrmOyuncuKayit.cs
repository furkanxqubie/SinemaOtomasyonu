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
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            Cinsiyet = "0";
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            Cinsiyet = "1";
        }
        public string Cinsiyet = "0";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YasHesaplama();
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "")
            {
                string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into tbl_Oyuncular (ADSOYAD,CINSIYET,YAS,BIYOGRAFI) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", Cinsiyet);
                kayit.Parameters.AddWithValue("@p3", byas);
                kayit.Parameters.AddWithValue("@p4", txtBiyografi.Text.ToString());
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                aracTemizle();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!!");
            }
        }
        void aracTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtBiyografi.Text = "";
            nGun.Value = 1;
            nAy.Value = 1;
            nYil.Value = 2023;
            rbErkek.Checked = true;
            rbKadin.Checked = false;
            Cinsiyet = "0";
            byas = "00";
            txtAd.Focus();

        }
        public string byas = "00";
        void YasHesaplama()
        {
            string dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString(); ;
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            byas = yas.ToString();
        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = txtBiyografi.Text.Length;
            int geri = 300 - karaktersayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 20)
            {
                lblKarakter.ForeColor = Color.FromArgb(84, 110, 122);
            }
            if (geri <= 20)
            {
                lblKarakter.ForeColor = Color.Orange;
            }
            if (geri <= 10)
            {
                lblKarakter.ForeColor = Color.Red;
            }
        }
    }
}
