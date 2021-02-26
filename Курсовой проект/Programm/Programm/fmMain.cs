using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeeMenu1_Click(object sender, EventArgs e)
        {
            tableMain tableMain = new tableMain();
            tableMain.Show();
            this.Hide();
        }

        private void Ref_Click(object sender, EventArgs e)
        {
            refMain refMain = new refMain();
            refMain.Show();
        }

        private void week1_Click(object sender, EventArgs e)
        {
            week week = new week();
            week.Show();
            this.Hide();
        }
    }
}
