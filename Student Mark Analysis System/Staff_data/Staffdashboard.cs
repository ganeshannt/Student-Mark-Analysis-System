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
    public partial class Staffdashboard : Form
    {
        public Staffdashboard()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Mark_entry.examselection r = new Mark_entry.examselection();
            r.Show();
            this.Hide();
        }
    }
}
