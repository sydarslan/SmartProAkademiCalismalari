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
    public partial class NormalForm : Form
    {
        public NormalForm()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string TemizVeri = TxtEklenecek.Text.Trim().ToString();
            TemizVeri = TemizVeri.ToUpper();
            int Mevcutindex  = listBox1.Items.IndexOf(TemizVeri);
            if (TemizVeri.Length > 0 && Mevcutindex == -1)
            {
                listBox1.Items.Add(TemizVeri);
                kontrol();
                TxtEklenecek.Text = "";
                TxtEklenecek.Focus();
            }
            else
            {
                if (TemizVeri.Length <= 0) //text içi boş yani veri yazmamış
                {
                    MessageBox.Show("Lütfen bir veri giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEklenecek.BackColor = Color.Orchid;
                    TxtEklenecek.Focus();
                }
                if(Mevcutindex > -1) // yazılan veri listede zaten mevcut
                {
                    MessageBox.Show("Girdiğiniz veri listede zaten mevcut", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEklenecek.BackColor = Color.Orchid;
                    TxtEklenecek.Focus();
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            string TemizSil = TxtSil.Text.Trim().ToString();
            TemizSil = TemizSil.ToUpper();
            int Silinecek = listBox1.Items.IndexOf(TemizSil);
            listBox1.SelectedIndex= Silinecek;
            DialogResult onay = MessageBox.Show("Kayıt Silmek istediğinize emin misiniz?","ONAY", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                if (Silinecek >= 0)
                {
                    listBox1.Items.RemoveAt(Silinecek);
                    kontrol();
                }
            }
        }

        private void BtnSecerek_Click(object sender, EventArgs e)
        {
            int Secilen = listBox1.SelectedIndex;
            if (Secilen > -1)
            {
                DialogResult onay = MessageBox.Show("Kayıt Silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    listBox1.Items.RemoveAt(Secilen);
                    kontrol();

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Secilen = listBox1.SelectedIndex;
            if (Secilen > -1)
            {
                TxtSil.Text = listBox1.Items[Secilen].ToString();
                TxtSil.Text = listBox1.Items[listBox1.SelectedIndex].ToString();

            }
        }

        private void ChbHepsiSil_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbHepsiSil.Checked == true)
            {
                listBox1.Items.Clear();
                ChbHepsiSil.Enabled = false;
                ChbHepsiSil.Checked = false;
            }
        }


        private void List_Load(object sender, EventArgs e)
        {
            kontrol();
        }

        private void kontrol()
        {
            if (listBox1.Items.Count > 0)
            {
                ChbHepsiSil.Checked = false;
                ChbHepsiSil.Enabled = true;
            }
            else
            {
                ChbHepsiSil.Enabled = false;
                ChbHepsiSil.Checked = false;
            }
        }



        private void NormalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
