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

namespace CrimeRecordDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NISAR-LENOVOYOG\\SPARTA;Initial Catalog=demo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Officer where ID = '" + IDtextbox.Text.Trim() + "'", con);
            SqlDataAdapter pda = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            pda.Fill(table);
            if (table.Rows.Count == 1)
            {
                Form4 signup = new Form4();
                this.Hide();
                signup.Show();

            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }
    }
}
