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
    public partial class YavruForm : Form
    {
        public YavruForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void YavruForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            string[] dizi = { "a", "b", "c", "d" };
            foreach (string item in dizi)
            {
                listBox1.Items.Add(item);

            }
        }
    }
}
