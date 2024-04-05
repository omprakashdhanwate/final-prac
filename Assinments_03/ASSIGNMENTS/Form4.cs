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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate username
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label3.Text = "Enter the Username";
                return;
            }
            else if (int.TryParse(textBox1.Text, out int usernameAsInt))
            {
                label3.Text = "Username cannot be a number. Letters only.";
                label3.BackColor = Color.Red;
                return;
            }

            // Validate password
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                label3.Text = "Enter the Password";
                return;
            }

            // Perform login validation
            if (textBox1.Text == textBox2.Text)
            {
                label3.Text = "LOGIN SUCCESS";
                label3.BackColor = Color.Green;
            }
            else
            {
                label3.BackColor = Color.Red;
                label3.Text = "WRONG DETAILS";
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
