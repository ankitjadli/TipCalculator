using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                label6.Text = ("Field must not be empty");
            }
            else
            {
                double bill, tip, total, noofpoeple,perperson;
                bill = double.Parse(textBox1.Text);
                noofpoeple = double.Parse(textBox3.Text);
                tip = double.Parse(textBox2.Text);
                if(tip>100)
                {
                    tip = 100;
                    textBox2.Text = "100";
                }
                if (noofpoeple > 1000)
                {
                    noofpoeple   = 1000;
                    textBox3.Text = "1000";
                }
                if (bill < 0 || noofpoeple < 0 || tip < 0)
                {
                    label6.Text = ("Negetive Text Field");
                }
                else
                {
                    label6.Text = ("");
                    total = (tip / 100) * bill;
                    total = Math.Round((total / noofpoeple),3);
                    perperson = Math.Round((total + (bill / noofpoeple)),3);
                    labeltax.Text = ("$") +  total.ToString();
                    label8.Text = ("$") + perperson.ToString();
                }
            }
        }
        
        private void tipminus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "0";
            }
            if (double.Parse(textBox2.Text)>0)
            {
                double temp = double.Parse(textBox2.Text) - 1;
                textBox2.Text = temp.ToString();
            }
        }

        private void tipplus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = "0";
            }
            if (double.Parse(textBox2.Text)<100)
            {
                double temp = double.Parse(textBox2.Text) + 1;
                textBox2.Text = temp.ToString();
            }
        }

        private void pplplus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "1";
            }
            if (double.Parse(textBox3.Text) < 100)
            {
                double temp = double.Parse(textBox3.Text) + 1;
                textBox3.Text = temp.ToString();
            }
        }

        private void pplminus_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "1";
            }
            if (double.Parse(textBox3.Text)>1)
            {
                double temp = double.Parse(textBox3.Text) - 1;
                textBox3.Text = temp.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
