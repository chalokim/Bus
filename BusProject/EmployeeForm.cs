﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusProject.Data;

namespace BusProject
{
    public partial class EmployeeForm: Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        string loginId;
        public EmployeeForm(string s)
        {
            InitializeComponent();
            loginId = s;
        }

        private void btnFormAddBus_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
