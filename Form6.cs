﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeRecordDB
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2= new Form2();
            this.Hide();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
