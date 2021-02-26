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
    public partial class ReportDish : Form
    {
        public ReportDish()
        {
            InitializeComponent();
        }

        private void ReportDish_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "canteenDataSet.Report". При необходимости она может быть перемещена или удалена.
            this.ReportTableAdapter.Fill(this.canteenDataSet.Report);

            this.reportViewer1.RefreshReport();
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            adfmMain adfm = new adfmMain();
            adfm.Show();
            this.Hide();
        }
    }
}
