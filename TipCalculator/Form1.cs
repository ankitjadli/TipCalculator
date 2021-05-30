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
        // This method Takes Values from all 3 TextBoxes and Calculate result.
        private void CalculateTip() 
        {
            // Below if statement checks if any of the 3 TextBoxes don't have any value
            // if not, lblEmptyFieldAlert shows a text.
            // else we calculate our result.


            if (String.IsNullOrEmpty(txtBillAmount.Text) || String.IsNullOrEmpty(txtTipPercentage.Text) || String.IsNullOrEmpty(txtNumberOfPeople.Text))
            {
                lblEmptyFieldAlert.Text = ("Field must not be empty");
            }
            else
            {
                double BillAmount,TipPercentage,TotalPerPerson,NumberOfPeople,TipPerPerson;

                // Below try block takes BillAmount and check if it exceeds maximum capacity
                // of "double" data type.


                try
                {
                    BillAmount = double.Parse(txtBillAmount.Text);
                }
                catch (System.OverflowException)
                {
                    // Resets BillAmount and update in TextBox.
                    BillAmount = 0;
                    txtBillAmount.Text = "0"; 
                }

                //Takes input from txtNumberOfPeople
                NumberOfPeople = double.Parse(this.txtNumberOfPeople.Text);

                //Takes input from txtTipPercentage
                TipPercentage = double.Parse(txtTipPercentage.Text);

                // Below "if" block checks if the current value of TipPercentage is current more that 100
                // if yes then reset it to 100.

                if (TipPercentage > 100)
                {
                    TipPercentage = 100;
                    txtTipPercentage.Text = "100";
                }

                // If NumberOfPeople is more than 1000 then set it to 1000  

                if (NumberOfPeople > 1000)
                {
                    NumberOfPeople = 1000;
                    this.txtNumberOfPeople.Text = "1000";
                }

                // If NumberOfPeople is set as 0 then reset

                if (NumberOfPeople==0)
                {
                    NumberOfPeople = 1;
                    this.txtNumberOfPeople.Text = "1";
                }

                // If all the 3 TextBoxes Have valid input then hide lblEmptyFieldAlert
                lblEmptyFieldAlert.Text = ("");

                //Below try block calculates Total_Per_Person and check if it exceeds maximum capacity
                // of "double" data type. If it does then reset it to $0.
                
                try
                {                    
                    TotalPerPerson = (TipPercentage / 100) * BillAmount;
                    TotalPerPerson = Math.Round((TotalPerPerson / NumberOfPeople), 3);
                }
                catch (System.OverflowException)
                {
                    TotalPerPerson = 0;
                    lblTipPerPersonResult.Text = "$0";
                }

                // Below try block calculates Tip_Per_Person and check if it exceeds maximum capacity
                // of "double" data type. If it does then reset it to $0.
                
                try
                {
                    TipPerPerson = Math.Round((TotalPerPerson + (BillAmount / NumberOfPeople)), 3);
                }
                catch (System.OverflowException)
                {
                    TipPerPerson = 0;
                    lblTotalPerPersonResult.Text = "$0";
                }

                lblTipPerPersonResult.Text = ("$") + TotalPerPerson.ToString();
                lblTotalPerPersonResult.Text = ("$") + TipPerPerson.ToString();
                
            }
        }

        // Below TipDecreasebtnClick Method changes value but first checking 
        // if TextBox is empty, then reset it to 0 ,
        // now check for limt 100(for tip%) if not then decrease value by 1.

        private void TipDecreasebtnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTipPercentage.Text))
            {
                txtTipPercentage.Text = "0";
            }
            else if (double.Parse(txtTipPercentage.Text) >0)
            {
                // Decrease Value inside txtTipPercentage by 1.
                double temp = double.Parse(txtTipPercentage.Text) - 1;
                // Update Value inside txtTipPercentage.
                txtTipPercentage.Text = temp.ToString();
            }
        }

        // Below TipIncreasebtnClick Method changes value but first checking 
        //  if TextBox is empty, then reset it to 0 ,
        //  now check if input value is >0 then increase value by 1.

        private void TipIncreasebtnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTipPercentage.Text))
            {
                txtTipPercentage.Text = "0";
            }
            else if (double.Parse(txtTipPercentage.Text) < 100)
            {
                // Increase Value inside txtTipPercentage by 1.
                double temp = double.Parse(txtTipPercentage.Text) + 1;
                // Update Value inside txtTipPercentage.
                txtTipPercentage.Text = temp.ToString();
            }
        }

        // Below NumberOfPeopleDecreasebtnClick Method changes value but first checking 
        // if TextBox is empty, then reset it to 1 ,
        // now check if input >1 if yes then decrease value by 1 and display value.

        private void NumberOfPeopleDecreasebtnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumberOfPeople.Text))
            {
                txtNumberOfPeople.Text = "1";
            }
            else if (double.Parse(txtNumberOfPeople.Text) > 1)
            {
                // Decrease Value inside txtNumberOfPeople by 1.
                double temp = double.Parse(txtNumberOfPeople.Text) - 1;
                // Update Value inside txtNumberOfPeople.
                txtNumberOfPeople.Text = temp.ToString();
            }
        }

        // Below NumberOfPeopleIncreasebtnClick Method changes value but first checking 
        // if TextBox is empty, then reset it to 1 ,
        // now check if input value is <100 then increase value by 1.

        private void NumberOfPeopleIncreasebtnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumberOfPeople.Text))
            {
                txtNumberOfPeople.Text = "1";
            }
            else if (double.Parse(txtNumberOfPeople.Text) < 1000)
            {
                // Decrease Value inside txtNumberOfPeople by 1.
                double temp = double.Parse(txtNumberOfPeople.Text) + 1;
                // Update Value inside txtNumberOfPeople.
                txtNumberOfPeople.Text = temp.ToString();
            }
        }

        // Below KeyPress Method checks if value entered is a digit or not.
        // if not then it wont be added to the TextBox.

        private void BillAmounttxtKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch)) && (ch != 8))
            {
                e.Handled = true;
            }
        }

         // Below TextChanged Method only have Digits as input as Filtering is already done by 
         // KeyPress method, On Every TextChange we calculate Tip.
         
        private void BillAmounttxtTextChanged(object sender, EventArgs e)
        {
            CalculateTip();
        }

         // Below TextChanged Method only have Digits as input as Filtering is already done by 
         // KeyPress method, On Every TextChange we calculate Tip.

        private void TipPercentagetxtTextChanged(object sender, EventArgs e)
        {
            CalculateTip();
        }

        // Below KeyPress Method checks if value entered is a digit or not.
        // if not then it wont be added to the TextBox.
        
        private void TipPercentagetxtKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // "ch!=8" make sure backspace is not entered as input
            if ((!Char.IsDigit(ch)) && (ch != 8))
            {
                e.Handled = true;
            }
        }

        // Below TextChanged Method only have Digits as input as Filtering is already done by 
        // KeyPress method, On Every TextChange we calculate Tip.
         
        private void NumberOfPeopletxtTextChanged(object sender, EventArgs e)
        {
            CalculateTip();
        }  
        
        // Below KeyPress Method checks if value entered is a digit or not.
        // if not then it wont be added to the TextBox.
        
        private void NumberOfPeopletxtKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((!Char.IsDigit(ch)) && (ch != 8))
            {
                e.Handled = true;
            }
        }

    }

}
