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
        private void Calculate_Tip()
        {
            if (String.IsNullOrEmpty(Bill_amount_Textbox.Text) || String.IsNullOrEmpty(Tip_Percentage_TextBox.Text) || String.IsNullOrEmpty(Number_Of_People_TextBox.Text))
            {
                label6.Text = ("Field must not be empty");
            }
            else
            {
                double Bill_Amount=0, Tip_Percentage=0, Total_Per_Person=0, Number_Of_People=0, Tip_Per_Person=0;
                try
                {
                    Bill_Amount = double.Parse(Bill_amount_Textbox.Text);
                }
                catch (System.OverflowException)
                {
                    Bill_Amount = 0;
                    Bill_amount_Textbox.Text = "0";
                }
                
                Number_Of_People = double.Parse(this.Number_Of_People_TextBox.Text);
                Tip_Percentage = double.Parse(Tip_Percentage_TextBox.Text);
                if (Tip_Percentage > 100)
                {
                    Tip_Percentage = 100;
                    Tip_Percentage_TextBox.Text = "100";
                }
                if (Number_Of_People > 1000)
                {
                    Number_Of_People = 1000;
                    this.Number_Of_People_TextBox.Text = "1000";
                }
                if (Number_Of_People==0)
                {
                    Number_Of_People = 1;
                    this.Number_Of_People_TextBox.Text = "1";
                }
                if (Bill_Amount < 0 || Number_Of_People < 0 || Tip_Percentage < 0)
                {
                    label6.Text = ("Negetive Text Field");
                }
                else
                {
                    label6.Text = ("");
                    try
                    {                    
                        Total_Per_Person = (Tip_Percentage / 100) * Bill_Amount;
                        Total_Per_Person = Math.Round((Total_Per_Person / Number_Of_People), 3);
                    }
                    catch (System.OverflowException)
                    {
                        Total_Per_Person = 0;
                        labeltax.Text = "$0";
                    }

                    try
                    {
                        Tip_Per_Person = Math.Round((Total_Per_Person + (Bill_Amount / Number_Of_People)), 3);
                    }
                    catch (System.OverflowException)
                    {
                        Tip_Per_Person = 0;
                        label8.Text = "$0";
                    }
                    labeltax.Text = ("$") + Total_Per_Person.ToString();
                    label8.Text = ("$") + Tip_Per_Person.ToString();
                }
            }
        }

        private void tipminus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Tip_Percentage_TextBox.Text))
            {
                Tip_Percentage_TextBox.Text = "0";
            }
            else if (double.Parse(Tip_Percentage_TextBox.Text) > 0)
            {
                double temp = double.Parse(Tip_Percentage_TextBox.Text) - 1;
                Tip_Percentage_TextBox.Text = temp.ToString();
            }
        }

        private void tipplus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Tip_Percentage_TextBox.Text))
            {
                Tip_Percentage_TextBox.Text = "0";
            }
            else if (double.Parse(Tip_Percentage_TextBox.Text) < 100)
            {
                double temp = double.Parse(Tip_Percentage_TextBox.Text) + 1;
                Tip_Percentage_TextBox.Text = temp.ToString();
            }
        }

        private void pplplus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Number_Of_People_TextBox.Text))
            {
                Number_Of_People_TextBox.Text = "1";
            }
            else if (double.Parse(Number_Of_People_TextBox.Text) < 100)
            {
                double temp = double.Parse(Number_Of_People_TextBox.Text) + 1;
                Number_Of_People_TextBox.Text = temp.ToString();
            }
        }

        private void pplminus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Number_Of_People_TextBox.Text))
            {
                Number_Of_People_TextBox.Text = "1";
            }
            else if (double.Parse(Number_Of_People_TextBox.Text) > 1)
            {
                double temp = double.Parse(Number_Of_People_TextBox.Text) - 1;
                Number_Of_People_TextBox.Text = temp.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
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
