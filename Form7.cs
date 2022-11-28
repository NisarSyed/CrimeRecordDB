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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Hide();
            form8.Show();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string query = "select * from Criminal";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            criminalGrid.DataSource = dt;
            con.Close();
        }

        private void refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string query = "select * from Criminal";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            criminalGrid.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void criminalcnictb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string sql = "select * from Criminal where ID='" + criminalcnictb.Text + "'";
            SqlCommand newcmd = new SqlCommand(sql, con);
            SqlDataAdapter sdr = new SqlDataAdapter(newcmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            criminalGrid.DataSource = dt;
            con.Close();
        }

        private void crimnametb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string sql = "select * from Criminal where Name='" + crimnametb.Text + "'";
            SqlCommand newcmd = new SqlCommand(sql, con);
            SqlDataAdapter sdr = new SqlDataAdapter(newcmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            criminalGrid.DataSource = dt;
            con.Close();
        }

        private void casenumtb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            string sql = "select * from Criminal where ID in (select criminalid from case_criminals where firid = @id)";
            SqlCommand newcmd = new SqlCommand(sql, con);
            newcmd.Parameters.AddWithValue("@id",casenumtb.Text);
            SqlDataAdapter sdr = new SqlDataAdapter(newcmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            criminalGrid.DataSource = dt;
            con.Close();
        }
    }
}
