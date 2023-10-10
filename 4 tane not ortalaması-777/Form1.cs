using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_tane_not_ortalaması_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yazili1, yazili2, yazili3, yazili4;
            double ortalama = 0;
            int not = 0;
            string durum = "GEÇTİ";

            yazili1 = Convert.ToInt32(txtYazili1.Text);
            yazili2 = Convert.ToInt32(txtYazili2.Text);
            yazili3 = Convert.ToInt32(txtYazili3.Text);
            yazili4 = Convert.ToInt32(txtYazili4.Text);

            ortalama = Convert.ToDouble((yazili1 + yazili2 + yazili3 + yazili4)) / 4;

            if (ortalama < 50)
            {
                not = 1;
                durum = "KALDI";
            }
            else if (ortalama < 60)
                not = 2;
            else if (ortalama < 70)
                not = 3;
            else if (ortalama < 85)
                not = 4;
            else if (ortalama <= 100)
                not = 5;

            lblDurum.Text = durum;
        }

    }
}
