using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Příklad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e) { for (int i = 0; i < 10; i++) { listBox1.Items.Add(rand.Next(0, 11)); } }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int selected = 0, soucet = 0; 
            foreach (int cislo in listBox1.SelectedItems) { selected++; soucet += cislo; }
            label1.Text = "Vybrané hodnoty: " + selected.ToString();
            label2.Text = "Součet vybraných hodnot: " + soucet.ToString();
        }
    }
}
