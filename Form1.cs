using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrimeRecordDB
{
    //Hey this is my first commit
    //Hey this is committed by Nisar
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NISAR-LENOVOYOG\\SPARTA;Initial Catalog=demo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where username = '" + userid.Text + "' and password = '" + password.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count ==1)
            {
                Form2 frm = new Form2();
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("User_name does not exist in our records!");
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }
    }
}
