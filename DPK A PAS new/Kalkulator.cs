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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DPK_A_PAS_new
{
    public partial class Kalkulator : Form
    {
        private decimal bil1, bil2;
        private string teks, teks2, text3;
        kalku kalku = new kalku();
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            bil2 = Convert.ToDecimal(textBox1.Text);
            teks2 = textBox3.Text;
            text3 = textBox2.Text;

            kalku.Bill1(bil1, teks);
            kalku.Bill2(bil2, teks2);

            decimal x = kalku.Bill1(bil1, teks), y = kalku.Bill2(bil2, teks2);
            kalku.hitung(text3, x,y);
            textBox1.Text = kalku.hitung(text3, x, y).ToString();

            textBox2.Text = "=";
            textBox3.Clear();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "000";
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "%";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            reset();
            textBox2.Clear();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            teks = textBox3.Text;
            textBox2.Text = ":";
            bil1 = Convert.ToDecimal(textBox1.Text);
            reset();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            teks = textBox3.Text;
            textBox2.Text = "x";
            bil1 = Convert.ToDecimal(textBox1.Text);
            reset();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            teks = textBox3.Text;
            textBox2.Text = "-";
            bil1 = Convert.ToDecimal(textBox1.Text);
            reset();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            teks = textBox3.Text;
            textBox2.Text = "+";
            bil1 = Convert.ToDecimal(textBox1.Text);
            reset();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void reset() //hapus texbox 1 dan 3
        {
            textBox1.Text = "0";
            textBox3.Clear();
        }
    }
}


