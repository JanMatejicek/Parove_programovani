using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vypocet_Click(object sender, EventArgs e)
        {
            try
            {
                int cislo1 = int.Parse(textBox1.Text);
                int cislo2 = int.Parse(textBox2.Text);
                int cislo3 = int.Parse(textBox3.Text);
                double vys;
                vys = ((double)cislo1 + (double)cislo2 + (double)cislo3) / 3;
                MessageBox.Show(vys.ToString());
                foreach (object objekt in groupBox1.Controls)
                {
                    if (objekt is Label)
                    {
                        string Label = listBox1.SelectedItem.ToString();
                        (objekt as Label).Text = Label;
                    }
                }
            }
            catch { MessageBox.Show("ERROR"); }
        }
    }
}
