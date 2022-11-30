using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeRecordDB
{
    public partial class Form10 : Form
    {
        public int id { get; set; } 
        public Form10()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loadwitness()
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            con.Open();
            string query2 = "select * from Witness where id in (select witness_id from [FIR/Witness] where FIR_ID = @firid)";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@firid", id);
            SqlDataAdapter sdr2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sdr2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            con.Open();
            string query = "select * from Suspect where id in (select suspect_id from [Suspects/FIR] where FIR_ID = @firid)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@firid",id);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

            loadwitness();
            
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
