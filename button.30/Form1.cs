using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aylar = comboBox1.SelectedIndex;
            aylar++;
            if(aylar == 1 || aylar==2 || aylar == 12)
            {
                label1.Text = "KIŞ MEVSİMİ";
                pictureBox1.Image = Properties.Resources.kis;
            }
            else if(aylar==3 || aylar==4 || aylar == 5)
            {
                label1.Text = "İLKBAHAR";
                pictureBox1.Image = Properties.Resources.ilkbahar;
            }
            else if(aylar== 6 || aylar==7 || aylar == 8)
            {
                label1.Text = "YAZ";
                pictureBox1.Image = Properties.Resources.yaz;
            }
            else
            {
                label1.Text = "SONBAHAR";
                pictureBox1.Image = Properties.Resources.sonbahar;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
