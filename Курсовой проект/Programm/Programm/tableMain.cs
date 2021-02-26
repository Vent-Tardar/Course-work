using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;

namespace Programm
{
    public partial class tableMain : Form
    {
        public tableMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refMain refMain = new refMain();
            refMain.Show();
        }

        private void понедельникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM dbo.Monday";

            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }

            connection.Close();

            dataGridView1.DataSource = records;
        }

        private void вторникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM dbo.Tuesday";

            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }

            connection.Close();

            dataGridView1.DataSource = records;
        }

        private void средаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM dbo.Wednesday";

            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }

            connection.Close();

            dataGridView1.DataSource = records;
        }

        private void четвергToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM dbo.Thursday";

            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }

            connection.Close();

            dataGridView1.DataSource = records;
        }

        private void пятницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connection;

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM dbo.Friday";

            connection.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            ArrayList records = new ArrayList();
            if (rdr.HasRows)
            {
                foreach (DbDataRecord rec in rdr)
                {
                    records.Add(rec);
                }
            }

            connection.Close();

            dataGridView1.DataSource = records;
        }

        private void понедельникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Monday monday = new Monday();
            monday.Show();
            this.Hide();
        }

        private void вторникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tuesday tuesday = new Tuesday();
            tuesday.Show();
            this.Hide();
        }

        private void средаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Wednesday wednesday = new Wednesday();
            wednesday.Show();
            this.Hide();
        }

        private void четвергToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thursday thursday = new Thursday();
            thursday.Show();
            this.Hide();
        }

        private void пятницаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Friday friday = new Friday();
            friday.Show();
            this.Hide();
        }
    }
}
