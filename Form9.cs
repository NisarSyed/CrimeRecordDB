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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            fillcombo1();
        }

        void fillcombo1()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select name from Station", con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("name", typeof(string));
                dt.Load(myreader);
                policestationbox2.ValueMember = "name";
                policestationbox2.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string query = "select * from FIR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string query = "select * from FIR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.Show();
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string sql = "select * from FIR where name='"+nametb.Text+"'";
            SqlCommand newcmd = new SqlCommand(sql, con);
            SqlDataAdapter sdr = new SqlDataAdapter(newcmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void placetb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string sql = "select * from FIR where place='"+placetb.Text+"'";
            SqlCommand newcmd = new SqlCommand(sql, con);
            SqlDataAdapter sdr = new SqlDataAdapter(newcmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
