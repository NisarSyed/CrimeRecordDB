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
    public partial class Form5 : Form
    {
        public class criminal
        {
            public int ID;
            public string Name;
            public string gender;
            public DateTime dob;
            public string pob;
            public string history;

            public criminal(int id, string name, string Gender, DateTime DOB, string POB, string HISTORY)
            {
                ID = id;
                Name = name;
                gender = Gender;
                dob  = DOB;
                pob = POB;
                history = HISTORY;
            }
        }

        List<criminal> list = new List<criminal>();
        public Form5()
        {
            InitializeComponent();
            this.statuscb.Items.Clear();
            this.statuscb.Items.Add(1);
            this.statuscb.Items.Add(0);

            this.gendercb.Items.Clear();
            this.gendercb.Items.Add("Male");
            this.gendercb.Items.Add("Female");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(new criminal(Convert.ToInt32(criminalcnictb.Text),criminalnametb.Text,gendercb.Text,dateTimePicker1.Value,criminalpobtb.Text,crimhistb.Text));
            listBox1.Items.Add(criminalnametb.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            con.Open();
            foreach (criminal b in list)
            {
                SqlCommand cmd = new SqlCommand("Insert into Criminal(ID,Name,gender,dob,pob,history)values(@id,@name,@gender,@dob,@pob,@history) Insert into case_criminals(FIRID,CriminalID)values(@firid,@id) update FIR set resolved_status = @status where ID=@firid", con);
                cmd.Parameters.AddWithValue("@firid",firidtb.Text);
                cmd.Parameters.AddWithValue("@status", statuscb.Text);
                cmd.Parameters.AddWithValue("@id", b.ID);
                cmd.Parameters.AddWithValue("@name", b.Name);
                cmd.Parameters.AddWithValue("@gender", b.gender);
                cmd.Parameters.AddWithValue("dob", b.dob);
                cmd.Parameters.AddWithValue("@pob", b.pob);
                cmd.Parameters.AddWithValue("@history", b.history);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Successfully updated record!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
}
