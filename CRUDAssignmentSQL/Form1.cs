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

namespace CRUDAssignmentSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = "server=MSCCS15;uid=sa;pwd=sql2024;database=master";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Established Successfully","Checking Connection");
            /*SqlCommand cmd = new SqlCommand("select * from Department", cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String Dno = dr[0].ToString();
                String Dname = dr[1].ToString();
                String Dbudget = dr[2].ToString();
                MessageBox.Show("Dept No: " + Dno + "Dept Name: " + Dname + " Budget: " + Dbudget);
            }*/
            cnn.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet202.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.masterDataSet202.Department);
            // TODO: This line of code loads data into the 'masterDataSet202.Department' table. You can move, or remove it, as needed.
           // this.departmentTableAdapter.Fill(this.masterDataSet202.Department);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS15;uid=sa;pwd=sql2024;database=master");
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.departmentTableAdapter.Fill(this.masterDataSet202.Department);
            this.departmentTableAdapter1.Fill(this.masterDataSet202.Department);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.departmentTableAdapter.Fill(this.masterDataSet202.Department);
            this.departmentTableAdapter1.Fill(this.masterDataSet202.Department);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS15;uid=sa;pwd=sql2024;database=master");
            con.Open();
            string qur = "UPDATE Department SET Dname='" + textBox5.Text + "',Dbudget='" + textBox6.Text + "' where Dno='" + textBox4.Text + "'";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated sucessfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.departmentTableAdapter.Fill(this.masterDataSet202.Department);
            this.departmentTableAdapter1.Fill(this.masterDataSet202.Department);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=MSCCS15;uid=sa;pwd=sql2024;database=master");
            con.Open();
            string qur = "Delete Department where Dno='" + textBox7.Text + "'";

            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted sucessfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
