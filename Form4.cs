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
        public class victim
        {
            public int ID;
            public string Name;
            public string Contact;
            public string address;

            public victim(int id,string name, string contact, string address)
            {
                ID = id;
                Name = name;
                Contact = contact;
                this.address = address;
            }   
        }
        public class suspect
        {
            public int ID;
            public string Name;
            public string Contact;
            public string address;
            public string history;

            public suspect(int iD, string name, string contact, string address, string history)
            {
                ID = iD;
                Name = name;
                Contact = contact;
                this.address = address;
                this.history = history;
            }   

        }
        public class witness
        {
            public int ID;
            public string Name;
            public string Contact;
            public string address;

            public witness(int iD, string name, string contact, string address)
            {
                ID = iD;
                Name = name;
                Contact = contact;
                this.address = address;
            }
        }
        List<victim> victimList = new List<victim>();
        List<suspect> suspectList = new List<suspect>();
        List<witness> witnessList = new List<witness>();
        public Form4()
        {
            InitializeComponent();
            Fillcombo1();
            Fillcombo2();
        }

        void Fillcombo1()
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
                policestationbox.ValueMember = "name";
                policestationbox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
            
        }

        void Fillcombo2()
        {
            
            SqlConnection constring = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            SqlCommand command = new SqlCommand("select Type from crime_type", constring);
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
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-79H0MFI\\SQLEXPRESS;Initial Catalog=crimerecordfinal;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FIR(ID,OfficerID,Name,Date,Place,Description,ReportedOn,Crime_type,Resolved_status)values(@id,@officerid,@name,@date,@place,@description,@reportedon,(select ID from crime_type where type = @crimetype) ,@resolvedstatus)",con);
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(firtb.Text.Trim()));
            cmd.Parameters.AddWithValue("@officerid", Convert.ToInt32(officertb.Text.Trim()));
            cmd.Parameters.AddWithValue("@name", victimnametb.Text.Trim());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@place", placetb.Text.Trim());
            cmd.Parameters.AddWithValue("@description", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@reportedon", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("crimetype", crimetypebox.Text);
            cmd.Parameters.AddWithValue("resolvedstatus", 0);
            cmd.ExecuteNonQuery();
            foreach (victim b in victimList)
            {
                SqlCommand cmd2 = new SqlCommand("Insert into Victim(ID,FIRID,Name,Contact,Address) values (@victimcnic,@firid,@Name,@Contact,@Address)", con);
                cmd2.Parameters.AddWithValue("@victimcnic",b.ID);
                cmd2.Parameters.AddWithValue("@firid", Convert.ToInt32(firtb.Text.Trim()));
                cmd2.Parameters.AddWithValue("@Name",b.Name);
                cmd2.Parameters.AddWithValue("@Contact",b.Contact);
                cmd2.Parameters.AddWithValue("@Address", b.address);
                cmd2.ExecuteNonQuery();
            }
            foreach (suspect c in suspectList)
            {
                SqlCommand cmd3 = new SqlCommand("Insert into Suspect(ID,Name,Contact,Address,History) values (@id,@name,@contact,@address,@history) Insert into [Suspects/FIR](suspect_ID,FIR_ID) values (@suspectid, @fir_ID)", con);
                cmd3.Parameters.AddWithValue("@id", c.ID);
                cmd3.Parameters.AddWithValue("@name", c.Name);
                cmd3.Parameters.AddWithValue("@contact", c.Contact);
                cmd3.Parameters.AddWithValue("@address", c.address);
                cmd3.Parameters.AddWithValue("@history", c.history);
                cmd3.Parameters.AddWithValue("@suspectid", c.ID);
                cmd3.Parameters.AddWithValue("@fir_ID", Convert.ToInt32(firtb.Text.Trim()));
                cmd3.ExecuteNonQuery();
            }
            foreach (witness d in witnessList)
            {
                SqlCommand cmd4 = new SqlCommand("Insert into Witness(ID,Name,Contact,Address) values (@id,@name,@contact,@address) Insert into [FIR/Witness](FIR_ID,Witness_ID) values (@fir_ID,@witnessid)", con);
                cmd4.Parameters.AddWithValue("@id", d.ID);
                cmd4.Parameters.AddWithValue("@name", d.Name);
                cmd4.Parameters.AddWithValue("@contact", d.Contact);
                cmd4.Parameters.AddWithValue("@address", d.address);
                cmd4.Parameters.AddWithValue("@witnessid", d.ID);
                cmd4.Parameters.AddWithValue("@fir_ID", Convert.ToInt32(firtb.Text.Trim()));
                cmd4.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Your record has been successfully added");
            this.Close();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 backto2 = new Form2();
            this.Hide();
            backto2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            victimList.Add(new victim(Convert.ToInt32(victimcnictb.Text.Trim()), victimnametb.Text, victimcontacttb.Text, victimaddresstb.Text));
            listBox1.Items.Add(victimnametb.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            suspectList.Add(new suspect(Convert.ToInt32(suspectcnictb.Text.Trim()), suspectnametb.Text, suspectcontacttb.Text, suspectaddresstb.Text, suspecthistb.Text));
            listBox2.Items.Add(suspectnametb.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            witnessList.Add(new witness(Convert.ToInt32(witnesscnictb.Text.Trim()), witnessnametb.Text, witnesscontacttb.Text, witnessaddresstb.Text));
            listBox3.Items.Add(witnessnametb.Text);
        }
    }
}
