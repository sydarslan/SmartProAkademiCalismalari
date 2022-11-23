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
    public partial class SinifOdevi : Form
    {
        public SinifOdevi()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0) //eğer kayıt varsa kontrol işlemine başla
            {
                for (int i = 0; i < listView1.Items.Count; i++) //tüm kayıtlarda dön
                {
                    if (listView1.Items[0].SubItems[0].Text == TxtUyeNo.Text) //girilen üyeno listview içindeki items içinde varsa
                    {
                        MessageBox.Show("Girilen üye no kayıtlı... Başka bir üye numarası giriniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);  //kayıt var mesajı gönder
                        TxtUyeNo.Text = "";
                        TxtAd.Text = "";
                        TxtSoyad.Text = "";
                        TxtUyeNo.Focus();
                        TxtUyeNo.BackColor = Color.LightPink;
                        break;
                    }
                    else   //girilen üyeno listview içindeki items içinde yoksa kayıt yap
                    {
                       
                        Kaydet();
                    }
                }
            }
            else //listview içinde herhangi bir kayıt yoksa direk kaydet
            {
               
                Kaydet();
            }

        }
        public void Kaydet()
        {
            string[] Girilen = {TxtUyeNo.Text , TxtAd.Text, TxtSoyad.Text, DtpDogumTarihi.Text};
            var satir = new ListViewItem(Girilen);
            if (TxtUyeNo.Text.Length>0 && TxtAd.Text.Length>0 && TxtSoyad.Text.Length> 0)
            {

                listView1.Items.Add(satir);
                MessageBox.Show("Kayıt Başarıyla gerçekleşti", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUyeNo.Text = "";
                TxtAd.Text = "";
                TxtSoyad.Text = "";
                TxtUyeNo.Focus();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz","HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TxtUyeNo_Enter(object sender, EventArgs e)
        {

            TxtUyeNo.BackColor = Color.AliceBlue;
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.White;
        }

        private void TxtAd_Enter(object sender, EventArgs e)
        {
            TxtUyeNo.BackColor = Color.White;
            TxtAd.BackColor = Color.AliceBlue;
            TxtSoyad.BackColor = Color.White;
        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {
            //Fazla click sorunu
        }

        private void TxtSoyad_Enter(object sender, EventArgs e)
        {
            TxtUyeNo.BackColor = Color.White;
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.AliceBlue;
        }

        private void TxtUyeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtUyeNo, TxtAd);
                if (BosMu)
                {
                    MessageBox.Show("Üye No Giriniz","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    TxtUyeNo.Focus();
                    TxtUyeNo.BackColor = Color.LightPink;
                }
                else
                {
                    TxtAd.Focus();
                }
                
            }
        }
        public bool Kontrol(TextBox GelenVeri, TextBox SonrakiVeri)
        {
            bool BosMu = true;
            if(GelenVeri.Text!= "")
            {
                BosMu = false;
                SonrakiVeri.Focus();
            }
           return BosMu;
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtAd, TxtSoyad);
                if (BosMu)
                {
                    MessageBox.Show("Adınızı Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAd.Focus();
                    TxtAd.BackColor = Color.LightPink;
                }
                else
                {
                    TxtSoyad.Focus();
                }

            }
        }

        private void TxtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtSoyad,TxtAd);
                if (BosMu)
                {
                    MessageBox.Show("Soyadınızı Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSoyad.Focus();
                    TxtAd.BackColor = Color.LightPink;
                }
                else
                {
                    DtpDogumTarihi.Focus();
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kullanılmayacak
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string uyeno = listView1.SelectedItems[0].SubItems[0].Text;
            string ad = listView1.SelectedItems[0].SubItems[1].Text;
            string soyad = listView1.SelectedItems[0].SubItems[2].Text;
            string tarih = listView1.SelectedItems[0].SubItems[3].Text;

            TxtUyeNo.Text = uyeno;
            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            DtpDogumTarihi.Text = tarih;




        }
    }
}
