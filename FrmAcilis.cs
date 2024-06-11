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
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar WHERE KADI=@username AND KSİFRE=@password", baglanti);
            sorgula.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaform frm = new FrmAnaform();
                frm.KisiAdiSoyadi = oku["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici Bulunamadi!");
            }
            baglanti.Close();
            
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();
        }
    }
}
