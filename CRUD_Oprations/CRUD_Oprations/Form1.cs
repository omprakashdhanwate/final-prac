using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'masterDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.masterDataSet.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection con = new sqlConnection(server)
        }
    }
}
