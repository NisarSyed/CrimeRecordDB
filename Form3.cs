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
         
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecorddbfinal;Integrated Security=True");
            /*
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
            }*/
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into Victim(ID) values (@victimid) Insert into Portal_credentials(ID,password) values (@victimid,@password)",con);
            cmd2.Parameters.AddWithValue("@victimid", Convert.ToInt32(textBox1.Text.Trim()));
            cmd2.Parameters.AddWithValue("@password", textBox3.Text.Trim());
            cmd2.ExecuteNonQuery();
            con.Close();
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
