﻿using BusProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        string username;
        public EmployeeForm(string s)
        {
            InitializeComponent();
            username = s;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            operationBindingSource.DataSource = Dao.Operation.GetAll();
        }
    }
}
