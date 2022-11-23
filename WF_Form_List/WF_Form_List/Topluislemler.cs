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
    public partial class Topluislemler : Form
    {
        public Topluislemler()
        {
            InitializeComponent();
        }

        private void BtnHepsi_Click(object sender, EventArgs e)
        {
            for(int i=0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void BtnHicbiri_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int aktarilacakverisayisi = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < aktarilacakverisayisi; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //birden fazla seçimde ilk seçileni tekrar tekrar yazmaması için
            int ToplamElemanSayisi = checkedListBox1.CheckedItems.Count;
            for(int i = 0; i < ToplamElemanSayisi; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Kaydet();
            //string[] Girilen = { TxtAd.Text, TxtSoyad.Text, TxtTel.Text };
            //var satir = new ListViewItem(Girilen);
            //listView1.Items.Add(satir);
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTel.Text = "";
            TxtAd.Focus();
        }
        private void TxtAd_Enter(object sender, EventArgs e)
        {
           
                TxtAd.BackColor = Color.Yellow;
                TxtSoyad.BackColor = Color.White;
                TxtTel.BackColor = Color.White;
            
                
            

        }
        private void TxtSoyad_Enter(object sender, EventArgs e)
        {
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.Yellow;
            TxtTel.BackColor = Color.White;
        }
        private void TxtTel_Enter(object sender, EventArgs e)
        {
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.White;
            TxtTel.BackColor = Color.Yellow;
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar)== 13)
            {
                if (TxtAd.Text != "")
                {
                    TxtSoyad.Focus();
                }
                else
                {
                    MessageBox.Show("Adınızı girin","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    TxtAd.Focus();
                }
            }
        }

        private void TxtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                TxtTel.Focus();
            }
        }

        private void TxtTel_TextChanged(object sender, EventArgs e) //yanlışlıkla açıldı
        {

        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                Kaydet();
            }
        }
        public void Kaydet()
        {
            string[] Girilen = { TxtAd.Text, TxtSoyad.Text, TxtTel.Text };
            var satir = new ListViewItem(Girilen);
            listView1.Items.Add(satir);
            TxtTel.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtAd.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
