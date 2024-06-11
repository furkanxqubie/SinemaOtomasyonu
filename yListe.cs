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
    public partial class yListe : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SinematikVT;Integrated Security=True");
        public yListe()
        {
            InitializeComponent();
        }

        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 10, FontStyle.Underline);
        }

        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 10, FontStyle.Regular);

        }

        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.FromArgb(17,28,43))
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler (KISI,TUR) values (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where KISI = @kisi AND TUR =@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "YÖNETMEN");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void yListe_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Secilenler where KISI = @kisi AND TUR=@Tur",baglanti);
            komut.Parameters.AddWithValue("@kisi",lblAdi.Text);
            komut.Parameters.AddWithValue("@tur","YÖNETMEN");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
            }
            baglanti.Close();
        }
    }
}
