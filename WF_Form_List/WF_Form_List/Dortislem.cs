using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Form_List
{
    public partial class Dortislem : Form
    {
        public Dortislem()
        {
            InitializeComponent();
        }

        private void BtnArtı_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(TxtSayi1.Text);
            sayi2 = Convert.ToInt32(TxtSayi2.Text);
            toplam = sayi1 + sayi2;
            LblSonuc.Text = "Sonuç : " + toplam;
        }

        private void BtnEksi_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, cikarma;
            sayi1 = Convert.ToInt32(TxtSayi1.Text);
            sayi2 = Convert.ToInt32(TxtSayi2.Text);
            cikarma = sayi1 - sayi2;
            LblSonuc.Text = "Sonuç : " + cikarma;
        }

        private void BtnCarpi_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, carpma;
            sayi1 = Convert.ToInt32(TxtSayi1.Text);
            sayi2 = Convert.ToInt32(TxtSayi2.Text);
            carpma = sayi1 * sayi2;
            LblSonuc.Text = "Sonuç : " + carpma;
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, bol;
            sayi1 = Convert.ToDouble(TxtSayi1.Text);
            sayi2 = Convert.ToDouble(TxtSayi2.Text);
            if (sayi2 == 0)
            {
                MessageBox.Show("Bölme işlemi için 2.sayı 0 olamaz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bol = sayi1 / sayi2;
                LblSonuc.Text = "Sonuç : " + bol;
            }
        }
    }
}
