﻿using System;
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
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void bttReservation_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Close();
        }

        private void bttCustomerInfo_Click(object sender, EventArgs e)
        {

        }

        private void bttReservationInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
