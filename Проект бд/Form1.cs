using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime;
namespace Проект_бд
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2.0.mdb;";

        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();

            textBox2.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
            private void button1_Click(object sender, EventArgs e)
        {
            string D = textBox1.Text;
            string ST = textBox2.Text;
            if (textBox2.Text == "")
            {
                ST = "0";
            }
            string CL = textBox3.Text;
            string NA = textBox4.Text;

            double D_1;
            double.TryParse(D, out D_1);
            double ST_1 = Convert.ToDouble(ST);
            double CL_1 = Convert.ToDouble(CL);
            double NA_1 = Convert.ToDouble(NA);
            string ST_N = ST.Replace(",", ".");
            string CL_N = CL.Replace(",", ".");

            if (checkBox1.Checked == true)
            {
                try
                {
                    string query = "SELECT [Мин разрушающая нагрузка, Н] FROM [Болт(ISO 898-1) Мин раз нагрузка, мелкий шаг] WHERE ([Диаметр резьбы D, мм]=" + D_1 + " and +  [Шаг резьбы, мм]=" + ST_N + " and +[Класс прочности]=" + CL_N + ")";

                    OleDbCommand command = new OleDbCommand(query, myConnection);
#pragma warning disable CS8602
                    string raz = command.ExecuteScalar().ToString();
#pragma warning disable CS8602
                    double raz_1 = Convert.ToDouble(raz);
                    if (raz_1 < NA_1)
                    {
                        textBox5.Text = "Минимальная разрушающая нагрузка превышена";
                    }
                    else
                        textBox5.Text = "Минимальная разрушающая нагрузка непревышена";
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    string query = "SELECT [Мин разрушающая нагрузка, Н] FROM [Болт(ISO 898-1) Мин раз нагрузка, крупный шаг] WHERE ([Диаметр резьбы D, мм]=" + D_1 + " and +[Класс прочности]=" + CL_N + ")";

                    OleDbCommand command = new OleDbCommand(query, myConnection);
#pragma warning disable CS8602
                    string raz = command.ExecuteScalar().ToString();
#pragma warning disable CS8602
                    double raz_1 = Convert.ToDouble(raz);
                    if (raz_1 < NA_1)
                    {
                        textBox5.Text = "Минимальная разрушающая нагрузка превышена";
                    }
                    else
                        textBox5.Text = "Минимальная разрушающая нагрузка непревышена";
                }
                catch
                {
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3() { ReturnForm = this }.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                textBox2.Show();
            }
            else
            {
                textBox2.Hide();
            }
        }
        
    }
}