using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRunRec_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmFAvsMS frm = new frmFAvsMS();
            frm.RunRec(this.txtFAFilePath.Text, this.txtMSFilePath.Text);
            frm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void frontArenaVsMorganStanleyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}