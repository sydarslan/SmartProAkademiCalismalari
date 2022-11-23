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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            // TxtEkle alanına girilen değeri ListBox' içine ekler..
            //  listBox1.Items.Add("Patlıcan");

            string Temiz = TxtEklenecek.Text.Trim().ToString();
            Temiz = Temiz.ToUpper();
           // Temiz = Temiz.ToLower();
            int MevcutSira = listBox1.Items.IndexOf(Temiz);
            
            if (Temiz.Length > 0 && MevcutSira == -1)
             
          //  if (TxtEklenecek.Text!="")
            {
                listBox1.Items.Add(Temiz);
                kontrol();
                //  listBox1.Items.Add(TxtEklenecek.Text);
                TxtEklenecek.Text = "";
                TxtEklenecek.Focus();
            }
            else
            {
                if (Temiz.Length <=0)
                {
                    MessageBox.Show("Lütfen Eklenecek veriyi giriniz !", "DİKKAT",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEklenecek.BackColor = Color.Bisque;
                    TxtEklenecek.Focus();
                }
                if (MevcutSira > -1) // (MevcutSira < 0)
                {
                    MessageBox.Show("Girilmek istenen veri listede mevcut!", "DİKKAT",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEklenecek.BackColor = Color.Bisque;
                    TxtEklenecek.Focus();
                }
                
            }
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // Listeden veri Sil..
            // 1- Txt alanına girilen kaydı sil
            // 2- Seçilen Kaydı Sil ..
            // 1-------------------------//
            string TemizSil = TxtSil.Text.Trim().ToString();
            TemizSil = TemizSil.ToUpper();
            int Silinecek = listBox1.Items.IndexOf(TemizSil);
            listBox1.SelectedIndex = Silinecek;
            DialogResult onay = MessageBox.Show("Emin misin?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay== DialogResult.Yes)
            {
                if (Silinecek >= 0) // Silinecek > -1
                {
                    listBox1.Items.RemoveAt(Silinecek);
                    kontrol();
                }
            }
           

        }

        private void BtnSecerekSil_Click(object sender, EventArgs e)
        {
            // Silme işleminde 2. Yöntem. Seçilen Kaydın Silinmesi
            int Secilen = listBox1.SelectedIndex;
            if (Secilen > -1)
            {
                // Buraya Emin misin? sorusu gelecek ..
                // Kullanıcı Evet der ise silecek..

                listBox1.Items.RemoveAt(Secilen);
                kontrol();
            }
            else
            {
                // Buraya hata mesajı gelecek.. 
                // Lütfen kayıt seçin vb...
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            if (secilen> -1)
            {
                TxtSil.Text = listBox1.Items[secilen].ToString();
                TxtSil.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }

        private void ChbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            // Check Box seçildiğinde ....
            if (ChbHepsi.Checked == true) // (ChbHepsi.Checked)
            {
                listBox1.Items.Clear();
                ChbHepsi.Checked = false;
                ChbHepsi.Enabled = false;
            }
        }

        private void List_Load(object sender, EventArgs e)
        {
            kontrol();
        }

        private void kontrol()
        {
            if (listBox1.Items.Count > 0)  //yeni kayıt girdiğinde hepsisil i aktif edecek
            {
                ChbHepsi.Enabled = true;
              //  ChbHepsi.Visible = true;
                ChbHepsi.Checked = false;

            }
            else
            {
                ChbHepsi.Enabled = false;
               // ChbHepsi.Visible = false;
                ChbHepsi.Checked = false;
            }
        }

        private void TxtSil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
