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
    public partial class FrmBiletDetay : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            barkodNoOlustur();
            bilgiGetir();
        }
        void bilgiGetir()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@kod";
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblFilmAdi.Text = oku["FILMADI"].ToString();
                lblFilmAdi2.Text = oku["FILMADI"].ToString();
                lblTelno.Text = oku["TELNO"].ToString();
                lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                lblBiletTuru.Text = oku["TUR"].ToString();
                lblSalonAdi.Text = oku["SALON"].ToString();
                lblSalon2.Text = oku["SALON"].ToString();
                lblTarih2.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblTarihSaat.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblIslemTarih.Text = oku["ISLEMSAATI"].ToString();
                lblKoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();
            }
            baglanti.Close();
        }

        void barkodNoOlustur()
        {

            Random rastgele = new Random();
            string karakterler = "5853527918880018740332488652041322350405808338474306532697660232492039363449218548120785567229387562";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
