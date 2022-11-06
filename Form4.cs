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

namespace CrimeRecordDB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Fillcombo1();
            Fillcombo2();
        }

        void Fillcombo1()
        {
            /*
            SqlConnection con = new SqlConnection("Data Source=NISAR-LENOVOYOG\\SPARTA;Initial Catalog=demo;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select (name) from Station", con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("name", typeof(string));
                dt.Load(myreader);
                policestationbox.ValueMember = "name";
                policestationbox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
            */
        }

        void Fillcombo2()
        {
            /*
            SqlConnection constring = new SqlConnection("Data Source=NISAR-LENOVOYOG\\SPARTA;Initial Catalog=demo;Integrated Security=True");
            SqlCommand command = new SqlCommand("select (Type) from crime_type", constring);
            SqlDataReader reader;
            try
            {
                constring.Open();
                reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("Type", typeof(string));
                data.Load(reader);
                crimetypebox.ValueMember = "Type";
                crimetypebox.DataSource = data;
                constring.Close();
            }
            catch (Exception)
            {

            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            if (firstnamebox.Text == "" || lastnamebox.Text == "")
            {
                MessageBox.Show("Please fill the mandatory fields!");
            }
            else if (passwordbox1.Text != passwordbox2.Text)
            {
                MessageBox.Show("Passwords do not match!");

            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection("Data Source=NISAR-LENOVOYOG\\SPARTA;Initial Catalog=demo;Integrated Security=True"))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("Addrecord", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@FirstName", firstnamebox.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Lastname", lastnamebox.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@officername", officernamebox.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@policestationame", policestationbox.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@crimetype", crimetypebox.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("Password", passwordbox1.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@dateofincident", dateTimePicker1.Value);
                    sqlcmd.Parameters.AddWithValue("@reportedon", dateTimePicker2.Value);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Record successfully added!");
                    
                }
            }
            */
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void policestationbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
