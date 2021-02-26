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
    public partial class adfmMain : Form
    {
        public adfmMain()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SeeMenu_Click(object sender, EventArgs e)
        {
            tableMain tableMain = new tableMain();
            tableMain.Show();
            this.Hide();
        }

        private void week_Click(object sender, EventArgs e)
        {
            week week = new week();
            week.Show();
            this.Hide();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            ReportDish report = new ReportDish();
            report.Show();
            this.Hide();
        }
    }
}
