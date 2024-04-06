using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Oprations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.masterDataSet1.Department);
            // TODO: This line of code loads data into the 'masterDataSet.Department' table. You can move, or remove it, as needed.
         // this.departmentTableAdapter.Fill(this.masterDataSet.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS01;uid=sa;pwd=sql2024;database=master");
            con.Open();
            string qur = "INSERT INTO Department VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.departmentTableAdapter.Fill(this.masterDataSet202.Department);
            this.departmentTableAdapter1.Fill(this.masterDataSet1.Department);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS01;uid=sa;pwd=sql2024;database=master");
            con.Open();
            string qur = "UPDATE Department SET D_Name='" + textBox5.Text + "',Dbudget='" + textBox6.Text + "' where D_No='" + textBox4.Text + "'";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated sucessfully");
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.departmentTableAdapter1.Fill(this.masterDataSet1.Department);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS01;uid=sa;pwd=sql2024;database=master");
            con.Open();
            string qur = "Delete Department where D_No='" + textBox9.Text + "'";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted sucessfully");
            textBox9.Text = "";
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.departmentTableAdapter1.Fill(this.masterDataSet1.Department);
        }
    }
}
