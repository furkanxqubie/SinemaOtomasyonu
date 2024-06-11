using System;
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
    public partial class FilmListesi : UserControl
    {
        public FilmListesi()
        {
            InitializeComponent();
        }

        private void btnFilmYukle_Click(object sender, EventArgs e)
        {
            FrmFilmDetay frm = new FrmFilmDetay();
            frm.idNo = lblIdNo.Text;
            frm.ShowDialog();
        }
    }
}
