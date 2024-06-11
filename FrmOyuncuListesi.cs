﻿using System;
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
    public partial class FrmOyuncuListesi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");

        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Tbl_Oyuncular";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
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

            SqlCommand ara = new SqlCommand("select * from Tbl_Oyuncular WHERE ADSOYAD LIKE '%" + txtAramaYap.Text + "%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
