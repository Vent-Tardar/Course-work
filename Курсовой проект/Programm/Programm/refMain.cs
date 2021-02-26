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
    public partial class refMain : Form
    {
        public refMain()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
