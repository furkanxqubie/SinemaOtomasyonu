﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinematik
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string KisiAdiSoyadi = "";
        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmFilmKayit frm = new FrmFilmKayit();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmBiletOlustur frm = new FrmBiletOlustur();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBiletSorgula frm = new FrmBiletSorgula();
            frm.ShowDialog();
        }
    }
}
