﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    public partial class Voucher : Form
    {
        public Voucher()
        {
            InitializeComponent();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_backToDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
