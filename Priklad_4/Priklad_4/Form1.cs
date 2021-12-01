using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priklad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vypoc_Click(object sender, EventArgs e)
        {
            try
            {
                int cislo = int.Parse(comboBox1.SelectedItem.ToString());
                ulong c1 = ulong.Parse(textBox1.Text);
                ulong c2 = ulong.Parse(textBox2.Text);
                ulong c3 = ulong.Parse(textBox3.Text);
                ulong vys = 1; ulong vys3 = 1; ulong vys2 = 1;
                string label = comboBox1.SelectedItem.ToString();
                label1.Text = label;
                for (int i = 0; i < cislo; i++)
                {
                    vys *= c1;
                    vys2 *= c2;
                    vys3 *= c3;
                }
                /*if(cislo == 1){vys = c1;vys2 = c2;vys3 = c3;}
                if(cislo == 2){vys2 = c2 * c2; vys = c1 * c1;vys3 = c3 * c3;}
                if(cislo == 3){vys3 = c3 * c3 * c3;vys = c1 * c1 * c1;vys2 = c2 * c2 * c2;}*/
                textBox1.Text = vys.ToString();
                textBox2.Text = vys2.ToString();
                textBox3.Text = vys3.ToString();
            }
            catch { MessageBox.Show("ERROR"); }
        }
    }
}
