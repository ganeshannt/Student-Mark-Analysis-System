﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mark_Analysis_System
{
    public partial class staffreg : Form
    {
        public staffreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csestaff c = new csestaff();
            c.Show();
            this.Hide();
        }
    }
}
