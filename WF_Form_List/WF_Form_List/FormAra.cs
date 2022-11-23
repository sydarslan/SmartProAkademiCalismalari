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
    public partial class FormAra : Form
    {
        public FormAra()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == TxtAra.Text)
                {
                    RbVar.Checked = true;
                    break;
                }
                else
                {
                    RbYok.Checked = true;
                }
            }
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                if (RbVar.Checked)
                {
                    listBox2.Items.Add("Listede" + " " + TxtAra.Text+ " " + "var");
                    break;
                }
            }

        }
    }
}
