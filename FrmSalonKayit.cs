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
    public partial class FrmSalonKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_Salonlar (SALONADI,KOLTUKSAYISI) VALUES (@p1,@p2)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ!");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİR DEĞER GİRİNİZ!");
            }
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
            kOlustur();
        }
        void kOlustur()
        {
            for (int i = 1; i < 200; i++)
            {
                cbKoltukSayisi.Items.Add(i);
            }
        }
        void listeGetir()
        {
            panelSalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SALONADI ASC", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblSalonAdi.Text = oku["SALONADI"].ToString();
                arac.lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
                panelSalon.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
