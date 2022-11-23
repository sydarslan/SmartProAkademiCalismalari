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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void normalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalForm normalform = new NormalForm();
            normalform.Show();
        }

        private void yavruFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YavruForm yavruform = new YavruForm();
            yavruform.MdiParent = this;
            yavruform.Show();

        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.MdiParent = this;
            list.Show();
        }

        private void dortislemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dortislem drtist = new Dortislem();
            drtist.MdiParent = this;
            drtist.Show();
        }

        private void topluislemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Topluislemler tislem = new Topluislemler();
            tislem.Show();
        }

        private void sınıfÖdeviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinifOdevi sinifodevi = new SinifOdevi();
            sinifodevi.Show();
        }

        private void listelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formAraToolStripMenuItem_Click(object sender, EventArgs e) //
        {
            FormAra formara = new FormAra();
            formara.Show();
        }
    }
}
