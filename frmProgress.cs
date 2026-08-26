using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VaderConsulting.CommandLine
{
    public partial class frmProgress : Form
    {
        public frmProgress()
        {
            InitializeComponent();
        }

        public void AddText(string Text)
        {
            try
            {
                txtProgress.AppendText(Text);
            }
            catch
            {

            }
        }

        private void frmProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
            }
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
