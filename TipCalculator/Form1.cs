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
        //This method Takes Values from all 3 TextBoxes and Calculate result.
        private void Calculate_Tip() 
        {
            /*Below if statement checks if any of the 3 TextBoxes don't have any value
             * if not, Empty_Field_Label shows a text.
             * else we calculate our result.
             */

            if (String.IsNullOrEmpty(Bill_Amount_Textbox.Text) || String.IsNullOrEmpty(Tip_Percentage_TextBox.Text) || String.IsNullOrEmpty(Number_Of_People_TextBox.Text))
            {
                Empty_Field_Alert_Label.Text = ("Field must not be empty");
            }
            else
            {
                double Bill_Amount,Tip_Percentage,Total_Per_Person,Number_Of_People,Tip_Per_Person;

                /*Below try block takes Bill_Amount and check if it exceeds maximum capacity
                 * of "double" data type.
                */

                try
                {
                    Bill_Amount = double.Parse(Bill_Amount_Textbox.Text);
                }
                catch (System.OverflowException)
                {
                    Bill_Amount = 0;
                    Bill_Amount_Textbox.Text = "0"; //resets Bill Amount
                }

                Number_Of_People = double.Parse(this.Number_Of_People_TextBox.Text); //Takes imput from TextBox

                Tip_Percentage = double.Parse(Tip_Percentage_TextBox.Text); //Takes imput from TextBox

                /*Below "if" blocks checks if the current value of Tip_Percentage is current more that 100
                 * , if Number_Of_People is more than 1000 then set it to 1000 and if Number_Of_People is set as 0 then 
                 * reset 
                 */

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

                Empty_Field_Alert_Label.Text = ("");//If all the 3 TextBoxes Have valid input then hide Empty_Field_Alert

                /*Below try block calculates Total_Per_Person and check if it exceeds maximum capacity
                * of "double" data type. If it does then reset it to $0.
                */

                try
                {                    
                    Total_Per_Person = (Tip_Percentage / 100) * Bill_Amount;
                    Total_Per_Person = Math.Round((Total_Per_Person / Number_Of_People), 3);
                }
                catch (System.OverflowException)
                {
                    Total_Per_Person = 0;
                    Tip_Per_Person_Result.Text = "$0";
                }

                /*Below try block calculates Tip_Per_Person and check if it exceeds maximum capacity
                * of "double" data type. If it does then reset it to $0.
                */

                try
                {
                    Tip_Per_Person = Math.Round((Total_Per_Person + (Bill_Amount / Number_Of_People)), 3);
                }
                catch (System.OverflowException)
                {
                    Tip_Per_Person = 0;
                    Total_Per_Person_Result.Text = "$0";
                }

                Tip_Per_Person_Result.Text = ("$") + Total_Per_Person.ToString();
                Total_Per_Person_Result.Text = ("$") + Tip_Per_Person.ToString();
                
            }
        }

        /*Below Button Clicks Method increases and decreases value but first checking 
         * if TextBox is empty if not, not check for limt 100(for tip%) and 1000(for number of people)
         * if TextBox is empty set it to 0(for tip%) and 1(for number of people)
         * */

        private void Tip_Decrease_Button_Click(object sender, EventArgs e)
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

        private void Tip_Increase_Button_Click(object sender, EventArgs e)
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

        private void Number_Of_People_Decrease_Button_Click(object sender, EventArgs e)
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

        private void Number_Of_People_Increase_Button_Click(object sender, EventArgs e)
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

        /*
         * Below KeyPress Method checks if charecter entered is a digit or not.
         * if not then it wont be added to the TextBox.
         */
        private void Bill_Amount_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        /*
         * Below TextChanged Method only have Digits as input as Filtering is already done by 
         * KeyPress method, On Every TextChange we calculate Tip.
         */

        private void Bill_Amount_Textbox_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void Tip_Percentage_TextBox_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void Tip_Percentage_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Number_Of_People_TextBox_TextChanged(object sender, EventArgs e)
        {
            Calculate_Tip();
        }

        private void Number_Of_People_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }

}
