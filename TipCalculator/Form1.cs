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

        private void button1_Click(object sender, EventArgs e)
        {
            double bill, tip, total,noofpoeple;
            bill = double.Parse(textBox1.Text);
            noofpoeple = double.Parse(textBox3.Text);
            tip = double.Parse(textBox2.Text);
            total = bill + (tip / 100) * bill;
            total = total / noofpoeple;
            labeltax.Text = total.ToString();

        }

    }
}
