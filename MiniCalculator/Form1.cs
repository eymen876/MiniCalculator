using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        private double num1;
        private static bool plus=false;
        private static bool minus=false;
        private static bool mult=false;
        private static bool div=false;
        bool[] exist = new bool[] { plus, minus, mult, div };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "1";
            else
                textBox.Text = current + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "2";
            else
                textBox.Text = current + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "3";
            else
                textBox.Text = current + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if ( current=="0")
                textBox.Text = "4";
            else
                textBox.Text = current + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "5";
            else
                textBox.Text = current + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "6";
            else
                textBox.Text = current + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "7";
            else
                textBox.Text = current + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "8";
            else
                textBox.Text = current + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "9";
            else
                textBox.Text = current + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (current == "0")
                textBox.Text = "0";
            else
                textBox.Text = current + "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            string current = textBox.Text;
            if (!current.Contains(","))
                textBox.Text = current + ",";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            result = 0;
            num1 = 0;
            plus = false;
            minus = false;
            mult = false;
            div = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                num1 += double.Parse(textBox.Text);
                textBox.Clear();
                plus = false;
            }
            else if (minus == true)
            {
                num1 -= double.Parse(textBox.Text);
                textBox.Clear();
                minus = false;
            }
            else if (mult == true)
            {
                num1 *= double.Parse(textBox.Text);
                textBox.Clear();
                mult = false;
            }
            else if (div == true)
            {
                num1 /= double.Parse(textBox.Text);
                textBox.Clear();
                div = false;
            }
            else
            {
                num1 = double.Parse(textBox.Text);
                textBox.Clear();
                plus = true;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                num1 += double.Parse(textBox.Text);
                textBox.Clear();
                plus = false;
            }
            else if (minus == true)
            {
                num1 -= double.Parse(textBox.Text);
                textBox.Clear();
                minus = false;
            }
            else if (mult == true)
            {
                num1 *= double.Parse(textBox.Text);
                textBox.Clear();
                mult = false;
            }
            else if (div == true)
            {
                num1 /= double.Parse(textBox.Text);
                textBox.Clear();
                div = false;
            }
            else
            {
                num1 = double.Parse(textBox.Text);
                textBox.Clear();
                minus = true;
            }
        }
        private void mult_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                num1 += double.Parse(textBox.Text);
                textBox.Clear();
                plus = false;
            }
            else if (minus == true)
            {
                num1 -= double.Parse(textBox.Text);
                textBox.Clear();
                minus = false;
            }
            else if (mult == true)
            {
                num1 *= double.Parse(textBox.Text);
                textBox.Clear();
                mult = false;
            }
            else if (div==true)
            {
                num1 /= double.Parse(textBox.Text);
                textBox.Clear();
                div = false;
            }
            else
            {
                num1 = double.Parse(textBox.Text);
                textBox.Clear();
                mult = true;
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                num1 += double.Parse(textBox.Text);
                textBox.Clear();
                plus = false;
            }
            else if (minus == true)
            {
                num1 -= double.Parse(textBox.Text);
                textBox.Clear();
                minus = false;
            }
            else if (mult == true)
            {
                num1 *= double.Parse(textBox.Text);
                textBox.Clear();
                mult = false;
            }
            else if (div == true)
            {
                num1 /= double.Parse(textBox.Text);
                textBox.Clear();
                div = false;
            }
            else
            {
                num1 = double.Parse(textBox.Text);
                textBox.Clear();
                div = true;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (plus == true)
            {
                num1 += double.Parse(textBox.Text);
                textBox.Clear();
                plus = false;
            }
            else if (minus == true)
            {
                num1 -= double.Parse(textBox.Text);
                textBox.Clear();
                minus = false;
            }
            else if (mult == true)
            {
                num1 *= double.Parse(textBox.Text);
                textBox.Clear();
                mult = false;
            }
            else if (div == true)
            {
                num1 /= double.Parse(textBox.Text);
                textBox.Clear();
                div = false;
            }
            textBox.Text = num1.ToString();
            plus = false;
            minus = false;
            mult = false;
            div = false;
        }
    }
}
