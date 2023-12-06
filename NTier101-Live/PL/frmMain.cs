﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmUserInsert frmUserInsert = new User.frmUserInsert();

            frmUserInsert.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmUser frmUser = new User.frmUser();

            frmUser.ShowDialog();
        }
    }
}
