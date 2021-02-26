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
    public partial class week : Form
    {
        public week()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            Monday monday = new Monday();
            monday.Show();
            this.Hide();
        }

        private void btnTue_Click(object sender, EventArgs e)
        {
            Tuesday tuesday = new Tuesday();
            tuesday.Show();
            this.Hide();
        }

        private void btnWen_Click(object sender, EventArgs e)
        {
            Wednesday wednesday = new Wednesday();
            wednesday.Show();
            this.Hide();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            Thursday thursday = new Thursday();
            thursday.Show();
            this.Hide();
        }

        private void btnFri_Click(object sender, EventArgs e)
        {
            Friday friday = new Friday();
            friday.Show();
            this.Hide();
        }
    }
}
