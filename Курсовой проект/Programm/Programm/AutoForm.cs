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
    public partial class AutoForm : Form
    {
        public string lastName;
        public string firstName;
        public string secondName;

        public AutoForm()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            connection.Open();

            string query = "SELECT * FROM users WHERE login = '" + tBUser.Text.Trim() + "' and password = '" + tBPass.Text.Trim() + "'";

            string query_1 = "SELECT last_name, first_name, second_name FROM users WHERE login = '" + tBUser.Text.Trim() + "' and password = '" + tBPass.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            SqlCommand cmd = new SqlCommand(query_1, connection);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            SqlDataReader dataReader = cmd.ExecuteReader();
            

            if (dataTable.Rows.Count == 1)
            {
                if (dataReader.Read())
                {
                    firstName = (string)dataReader["first_name"];
                    lastName = (string)dataReader["last_name"];
                    secondName = (string)dataReader["second_name"];
                }

                connection.Close();

                firstName = firstName.Replace(" ", "");
                lastName = lastName.Replace(" ", "");
                secondName = secondName.Replace(" ", "");

                string txt = "Здравствуйте, " + lastName + " " + firstName + " " + secondName + "!";

                MessageBox.Show(txt);

                if ((tBUser.Text == "admin") && (tBPass.Text == "admin"))
                {
                    adfmMain adfm = new adfmMain();
                    adfm.Show();
                    this.Hide();
                }
                else
                {
                    fmMain fmMain = new fmMain();
                    this.Hide();
                    fmMain.Show();
                }
            }
            else
            {
                MessageBox.Show("Введенные данные не верны","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBPass.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
