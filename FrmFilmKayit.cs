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
    public partial class FrmFilmKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public FrmFilmKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();
        }
        void verileriSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rB6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";
        }

        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
        }
        string resimYolu = "";
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

        private void txtFilmDetayi_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = txtFilmDetayi.Text.Length;
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

        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            BugununTarihi();
            txtFilmAdi.Focus();
        }
        void BugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;
        }
        void yListesiGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            fYonPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListe arac = new yListe();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYonPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void oListesiGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListe arac = new oListe();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtOyuncuAra_MouseMove(object sender, MouseEventArgs e)
        {
            lblOyuncuAra.Visible = true;
        }
        private void txtOyuncuAra_MouseLeave(object sender, EventArgs e)
        {
            lblOyuncuAra.Visible = false;

        }
        private void txtYonetmenAra_MouseMove(object sender, MouseEventArgs e)
        {
            lblYonetmenAra.Visible = true;
        }

        private void txtYonetmenAra_MouseLeave(object sender, EventArgs e)
        {
            lblYonetmenAra.Visible = false;
        }

        private void txtYonetmenAra_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }
        void yonetmenAra()
        {
            string sorgu = "select * from Tbl_Yonetmenler WHERE ADSOYAD LIKE '%" + txtYonetmenAra.Text + "%' collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fYonPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListe arac = new oListe();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYonPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            oyuncuAra();
        }
        void oyuncuAra()
        {
            string sorgu = "select * from Tbl_Oyuncular WHERE ADSOYAD LIKE '%" + txtOyuncuAra.Text + "%' collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListe arac = new oListe();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            if (lblAsk.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAsk.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAsk.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblGerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblGerilim.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblDrama_Click(object sender, EventArgs e)
        {
            if (lblDrama.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblDrama.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblDrama.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblTurkce_Click(object sender, EventArgs e)
        {
            if (lblTurkce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblTurkce.ForeColor = Color.FromArgb(229, 57, 53);
            }
            else
            {
                lblTurkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl_Altyazi_Click(object sender, EventArgs e)
        {
            if (lbl_Altyazi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_Altyazi.ForeColor = Color.FromArgb(229, 57, 53);
            }
            else
            {
                lbl_Altyazi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl_Ingilizce_Click(object sender, EventArgs e)
        {
            if (lbl_Ingilizce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_Ingilizce.ForeColor = Color.FromArgb(229, 57, 53);
            }
            else
            {
                lbl_Ingilizce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }
        private void lblKorkuSiddet_Click(object sender, EventArgs e)
        {
            if (lblKorkuSiddet.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorkuSiddet.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lblKorkuSiddet.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblOlumsuz_Click(object sender, EventArgs e)
        {
            if (lblOlumsuz.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblOlumsuz.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lblOlumsuz.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (lblCinsellik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblCinsellik.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lblCinsellik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (lblGenel.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblGenel.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lblGenel.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (lbl13.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl13.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lbl13.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            VizyonTarihiHesapla();
        }
        string vTarih = "";
        string durum = "0";
        void VizyonTarihiHesapla()
        {
            vTarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime BugunTarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - BugunTarihi;
            if (tSpan.TotalDays < 0)
            {
                MessageBox.Show("GEÇMİŞ TARİHLERE FİLM EKLENMESİ YAPILAMAZ!");
                BugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " FİLMİ BUGÜN VİZYONDA!");
            }
            else
            {
                durum = "0";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + " GÜN SONRA VİZYONA GİRECEKTİR!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        string yonetmen = "";
        string oyuncu = "";
        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='YÖNETMEN'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='OYUNCU'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void temizlemeMetodu()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            txtFilmAdi.Focus();
            verileriSil();
            yListesiGetir();
            oListesiGetir();
            BugununTarihi();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            secilenYonetmen();
            secilenOyuncu();

            tur();
            ozellik();
            bicim();

            if (txtFilmAdi.Text != "" && txtFilmDetayi.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu != "" && vTarih != "" && secilenBicim != "" && secilenOzellik != "" && secilenTur != "")
            {
                string sorgu = "insert into Tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }

                komut.Parameters.AddWithValue("@p7", txtFilmDetayi.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", lblRating.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE EKLENDİ!");
                temizlemeMetodu();
            }
            else
            {
                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ!");
            }


            
        }
        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        void tur()
        {
            foreach (Control arac in grBTur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenTur += ", " + arac.Text.ToString();
                    }
                }
            }
        }
        void ozellik()
        {
            foreach (Control arac in grBOzellikler.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenOzellik += ", " + arac.Text.ToString();
                    }
                }
            }
        }
        void bicim()
        {
            foreach (Control arac in grBBicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenBicim += ", " + arac.Text.ToString();
                    }
                }
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKomedi.ForeColor = Color.FromArgb(41, 57, 85);
            }
            else
            {
                lblKomedi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void txtFilmAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}