﻿using System;
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
    public partial class Monday : Form
    {
        public Monday()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rass_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=canteen;Integrated Security=True");

            string query = "SELECT * FROM users WHERE card_number = '" + textBox1.Text.Trim()+"'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            double sal_1 = 0;
            double sal_2 = 0;
            double sal_3 = 0;
            double soup = 0;
            double secD_1 = 0;
            double secD_2 = 0;
            double secD_3 = 0;
            double g_1 = 0;
            double g_2 = 0;
            double n_1 = 0;
            double n_2 = 0;
            double n_3 = 0;
            double n_4 = 0;
            double n_5 = 0;
            double n_6 = 0;
            double n_7 = 0;
            double v_1 = 0;
            double v_2 = 0;
            double v_3 = 0;
            double v_4 = 0;
            double v_5 = 0;
            double v_6 = 0;
            double sk_1 = 0;
            double sk_2 = 0;

            //Салат с курой и ветчиной
            if (checkBox1.Checked == true)
            {
                sal_1 = 40.00;
            }

            //Салат студенческий
            if (checkBox2.Checked == true)
            {
                sal_2 = 30.00;
                sk_1 = 5;
            }

            //Яйцо с гарниром, майонезом
            if (checkBox3.Checked == true)
            {
                sal_3 = 29.00;
            }

            //Борщ из св. капусты со сметаной
            if (checkBox4.Checked == true)
            {
                soup = 35.00;
            }

            //Котлета жареная мясная с гарниром
            if (checkBox5.Checked == true)
            {
                if ((checkBox8.Checked == true) || (checkBox9.Checked == true))
                {
                    secD_1 = 60.00;
                }
                else
                {
                    MessageBox.Show("Вы не выбрали гарнир");
                }
            }

            //Филе куриное запеченное с гарниром
            if (checkBox6.Checked == true)
            {
                if ((checkBox8.Checked == true) || (checkBox9.Checked == true))
                {
                    secD_2 = 78.00;
                }
                else
                {
                    MessageBox.Show("Вы не выбрали гарнир");
                }
            }

            //Тефтели в соусе с гарниром
            if (checkBox7.Checked == true)
            {
                if ((checkBox8.Checked == true) || (checkBox9.Checked == true))
                {
                    secD_3 = 74.00;
                }
                else
                {
                    MessageBox.Show("Вы не выбрали гарнир");
                }
            }

            //Картофельное пюре с соусом
            if (checkBox8.Checked == true)
            {
                if ((checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true))
                {
                    g_1 = 0;
                }
                else
                {
                    g_1 = 22.00;
                }
            }

            //Макароны с соусом
            if (checkBox9.Checked == true)
            {
                if ((checkBox5.Checked == true) || (checkBox6.Checked == true) || (checkBox7.Checked == true))
                {
                    g_2 = 0;
                }
                else
                {
                    g_2 = 22.00;
                }
            }

            //Чай с сахаром, лимоном
            if (checkBox10.Checked == true)
            {
                n_1 = 6.00;
            }

            //Чай разовый с сахаром, лимоном
            if (checkBox11.Checked == true)
            {
                n_2 = 12.00;
            }

            //Компот ягодный
            if (checkBox12.Checked == true)
            {
                n_3 = 15.00;
            }

            //Компот из сухофруктов
            if (checkBox13.Checked == true)
            {
                n_4 = 15.00;
            }

            //Кофе растворимый с сахаром
            if (checkBox14.Checked == true)
            {
                n_5 = 20.00;
            }

            //Сок в ассортименте
            if (checkBox15.Checked == true)
            {
                n_6 = 20.00;
            }

            //Лимонад в ассортименте
            if (checkBox16.Checked == true)
            {
                n_7 = 50.00;
            }

            //Сосиска в тесте
            if (checkBox17.Checked == true)
            {
                v_1 = 35.00;
            }

            //Беляш жареный с мясом
            if (checkBox18.Checked == true)
            {
                v_2 = 30.00;
            }

            //Булочка маковая
            if (checkBox19.Checked == true)
            {
                v_3 = 20.00;
            }

            //Булочка с корицей
            if (checkBox20.Checked == true)
            {
                v_4 = 20.00;
            }
            
            //Пицца с колбасой
            if (checkBox21.Checked == true)
            {
                v_5 = 40.00;
                sk_2 = 10;
            }

            //Хлеб
            if (checkBox22.Checked == true)
            {
                v_6 = 3;
            }

            double sum = sal_1 + sal_2 + sal_3 + soup + secD_1 + secD_2 + secD_3 + g_1 + g_2 + n_1 + n_2 + n_3 + n_4 + n_5 + n_6 + n_7 + v_1 + v_2 + v_3 + v_4 + v_5 + v_6;

            label8.Text = sum.ToString();

            Boolean checkboxFlag = false;

            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        checkboxFlag = true;;

                    }
                }
            }
            if (!checkboxFlag)
            {
                DialogResult uncheckederror = MessageBox.Show("Вы не выбрали ни одного блюда, расчет не возможен",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }

            if (textBox1.Enabled == true)
            {
                if (dataTable.Rows.Count == 1)
                {
                    if((sk_1 != 0) && (sk_2 != 0))
                    {
                        double c = sk_2 * (sum / 100);
                        double card_1 = sum - c;
                        label8.Text = card_1.ToString();
                    }
                    else if ((sk_1 != 0) && (sk_2 == 0))
                    {
                        double c = sk_1 * (sum / 100);
                        double card_1 = sum - c;
                        label8.Text = card_1.ToString();
                    }
                    else if ((sk_1 == 0) && (sk_2 != 0))
                    {
                        double c = sk_2 * (sum / 100);
                        double card_1 = sum - c;
                        label8.Text = card_1.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            week week = new week();
            week.Show();
            this.Hide();
        }
    }
}
