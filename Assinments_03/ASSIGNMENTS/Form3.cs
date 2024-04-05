using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENTS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            double newprice;
            int n = Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked)
            {
                price = n * 125;
            }
            else if (checkBox2.Checked) { 
                price = n * 175;
            }
            else
            {
                price = n * 250;
            }
            if(textBox2.Text == "TRUEBLUE")
            {
                newprice = (double)price * 0.9;
            }
            else
            {
                newprice = (double)price;
            }
            double Final = newprice + (newprice * 0.09);
            label7.Text = Final.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
