using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinematik
{
    public partial class FrmBiletOlustur : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmBiletOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
            biletNoOlustur();
        }

        void biletNoOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "5853527918880018740332488652041322350405808338474306532697660232492039363449218548120785567229387562";
            string kod = "";
            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();
        }
        void FilmAdiGetir()
        {
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelenTarih = oku["TARIH"].ToString();
                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                DateTime bugun = DateTime.Today;
                TimeSpan timespan = fTarih - bugun;
                if (timespan.TotalDays <= 0)
                {
                    cbFilmAdi.Items.Add(oku["ADI"].ToString());
                }
            }
            baglanti.Close();
        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sorgu = "SELECT DISTINCT TARIH FROM Tbl_Kontrol WHERE FILMADI=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarih.Items.Add(oku["TARIH"].ToString());
            }
            baglanti.Close();
        }
        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSEANS.Controls.Clear();
            string saatler = "";

            string sorgu = "SELECT DISTINCT SAAT FROM Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.FromArgb(249, 164, 26);
                rnd.FlatStyle = FlatStyle.Flat;
                rnd.Width = 70;
                rnd.Font = new System.Drawing.Font("Segoe UI Semibold", 10);
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                panelSEANS.Controls.Add(rnd);
            }
            baglanti.Close();
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSEANS.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text;
                    cbSalon.Items.Clear();

                    string sorgu = "SELECT DISTINCT SALONADI FROM Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbSalon.Items.Add(oku["SALONADI"].ToString());
                    }
                    baglanti.Close();
                }
            }
        }
        void biletNoSorgula()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetMETODU();
            }
            else
            {
                biletNoOlustur();
                baglanti.Close();
                biletNoOlustur();
            }
            baglanti.Close();
        }
        void kaydetMETODU()
        {
            {

                string sorgu = "insert into Tbl_Biletler (BKOD, ADSOYAD, TELNO, KOLTUKNO, FILMADI, TARIH, SAAT, SALON, TUR, ISLEMSAATI) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
                baglanti.Close();
                baglanti.Open();
                SqlCommand kayit = new SqlCommand(sorgu, baglanti);
                kayit.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
                kayit.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToUpper().ToString());
                kayit.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
                kayit.Parameters.AddWithValue("@p4", txtKoltuklar.Text.ToString());
                kayit.Parameters.AddWithValue("@p5", cbFilmAdi.Text.ToString());
                kayit.Parameters.AddWithValue("@p6", cbTarih.Text.ToString());
                kayit.Parameters.AddWithValue("@p7", lblSeansSec.Text.ToString());
                kayit.Parameters.AddWithValue("@p8", cbSalon.Text.ToString());
                kayit.Parameters.AddWithValue("@p9", cbBiletTuru.Text.ToString());
                kayit.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
                kayit.ExecuteNonQuery();
                baglanti.Close();

                string sorgu2 = "UPDATE Tbl_Kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);
                string yeniKoltuklar = lblGelenKoltuk.Text.ToString() == "" ? txtKoltuklar.Text.ToString() : lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString();
                guncelle.Parameters.AddWithValue("@numara", yeniKoltuklar);
                guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
                guncelle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("BİLET SATIŞI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                salonDurumGeldi();

                lblGelenKoltuk.Text = "";
                listeGelenKoltuk.Items.Clear();
                lbBelirlenen.Items.Clear();
                txtKoltuklar.Text = "";

            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBarkod.Text != "" && txtKoltuklar.Text != "" && txtTelNo.Text != "" && cbBiletTuru.Text != "" && cbFilmAdi.Text != "" && cbSalon.Text != "" && cbTarih.Text != "")
            {
                biletNoSorgula();
            }
            else
            {
                MessageBox.Show("LÜTFEN BÜTÜN ALANLARI EKSİKSİZ DOLDURUNUZ!");
            }
        }
        void sectiklerimiz()
        {
            txtKoltuklar.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;
            }
            if (txtKoltuklar.Text.Length > 2)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Black)
            {
                MessageBox.Show("BU KOLTUK DOLUDUR!");
            }
            else
            {
                if (btn.ForeColor == Color.FromArgb(249, 164, 26))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sari);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Blue;
                    lbBelirlenen.Items.Add(btn.Text);
                    sectiklerimiz();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.mavi);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Yellow;
                    lbBelirlenen.Items.Remove(btn.Text);

                }
            }
        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }

        void salonDurumGeldi()
        {
            string sorgu = "SELECT * FROM Tbl_Salonlar WHERE SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
            }
            baglanti.Close();
            koltukGetir();

            DOLDUR();
        }
        void DOLDUR()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();
                //
                if (i <= 9)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 18)
                {
                    btn.Text = "B" + (i - 9).ToString();
                    btn.Name = "B" + (i - 9).ToString();
                }
                else if (i <= 27)
                {
                    btn.Text = "C" + (i - 9 * 2).ToString();
                    btn.Name = "C" + (i - 9 * 2).ToString();
                }
                else if (i <= 36)
                {
                    btn.Text = "D" + (i - 9 * 3).ToString();
                    btn.Name = "D" + (i - 9 * 3).ToString();
                }
                else if (i <= 45)
                {
                    btn.Text = "E" + (i - 9 * 4).ToString();
                    btn.Name = "E" + (i - 9 * 4).ToString();
                }
                else if (i <= 54)
                {
                    btn.Text = "F" + (i - 9 * 5).ToString();
                    btn.Name = "F" + (i - 9 * 5).ToString();
                }
                else if (i <= 63)
                {
                    btn.Text = "G" + (i - 9 * 6).ToString();
                    btn.Name = "G" + (i - 9 * 6).ToString();
                }
                else if (i <= 72)
                {
                    btn.Text = "H" + (i - 9 * 7).ToString();
                    btn.Name = "H" + (i - 9 * 7).ToString();
                }
                else if (i <= 81)
                {
                    btn.Text = "J" + (i - 9 * 8).ToString();
                    btn.Name = "J" + (i - 9 * 8).ToString();
                }
                else if (i <= 90)
                {
                    btn.Text = "K" + (i - 9).ToString();
                    btn.Name = "K" + (i - 9).ToString();
                }

                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12);

                btn.BackColor = Color.White;
                btn.ForeColor = Color.Purple;
                btn.Click += Btn_Click;

                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.kir);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.Black;
                    btn.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.mavi);
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.ForeColor = Color.FromArgb(249, 164, 26);
                    btn.TextAlign = ContentAlignment.MiddleRight;
                }
                KoltukPaneli.Controls.Add(btn);

            }
        }
        void koltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "SELECT * FROM Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblGelenKoltuk.Text += " ," + oku["KOLTUKLAR"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
            }
            baglanti.Close();
            koltukAyirma();
        }
        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cbBiletTuru.Text = "";
            cbSalon.Text = "";
            cbTarih.Text = "";
            txtBarkod.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            lblYonetmenAra.Text = "";
            cbSalon.Items.Clear();
            cbTarih.Items.Clear();
            cbBiletTuru.Items.Clear();
            cbBiletTuru.Items.Add("YETİŞKİN");
            cbBiletTuru.Items.Add("ÖĞRENCİ");
            biletNoOlustur();
            panelSEANS.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lbBelirlenen.Items.Clear();
            cbFilmAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            FilmAdiGetir();
            txtAdSoyad.Focus();

        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
