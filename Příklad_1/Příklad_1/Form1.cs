using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Příklad_jedna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Q_Click(object sender, EventArgs e) { textBox.Text += (sender as Button).Text; }

        private void button_zasifrovat_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string txt = textBox.Text;
            foreach (char znak in txt)
            {
                char Char;
                if (znak == ' ' || znak == '!' || znak == '?' || znak == ',' || znak == '.') { Char = znak; }
                else { Char = (char)((int)znak + 3); }
                textBox1.AppendText(Char.ToString());
            }
        }

        private void button_vymazat_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox.Text = ""; }
    }
}
