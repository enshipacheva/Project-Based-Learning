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
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rezba.mdb;";

        private OleDbConnection myConnection;

        public Form ReturnForm;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();

            textBox2.Hide();

            label7.Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        public static int Td2_1, TD2_1, EI_1, es_1;
        public static double raz_1, ST_1;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var D = textBox1.Text;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //var  ST = textBox2.Text;
            double D_1 = Convert.ToDouble(textBox1.Text);

            //if (textBox2.Text == "")
            //{
            //    ST = "0";
            //}
            //string CL = textBox3.Text;
            //string NA = textBox4.Text;
            //string OO1 = textBox5.Text;
            //Char OO1_1 = Convert.ToChar(OO1);
            //string OO2 = textBox6.Text;
            //Char OO2_2 = Convert.ToChar(OO2);
            //double D_1 = Convert.ToDouble(D);
            //double ST_1 = Convert.ToDouble(ST);
            //double CL_1 = Convert.ToDouble(CL);
            //double NA_1 = Convert.ToDouble(NA);
            //string ST_N = ST.Replace(",", ".");
            //string CL_N = CL.Replace(",", ".");

            if (checkBox1.Checked == true)
            { 
//                try
//                {
//                    string query = "SELECT [Средний диаметр резьбы, мм] FROM [Лист1] WHERE ([Номинальный диаметр резьбы, мм]=" + D_1 + " and + [Шаг резьбы, мм]=" + ST_N + ")";

//                    OleDbCommand command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                    string raz = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                    raz_1 = Convert.ToDouble(raz);
//                    label7.Text = raz;
//                    label7.Show();
//                }
//                catch
//                {
//                }              
            }
            else
            {
                try
                {
//                    string query = "SELECT [Средний диаметр резьбы, мм] FROM [Лист1] WHERE ([Номинальный диаметр резьбы, мм]=" + D_1 + ")";

//                    OleDbCommand command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                    string raz = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                    raz_1 = Convert.ToDouble(raz);
//                    query = "SELECT [Шаг резьбы, мм] FROM [Лист1] WHERE ([Номинальный диаметр резьбы, мм]=" + D_1 + ")";

//                    command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                    ST = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                    ST_1 = Convert.ToDouble(ST);
//                    ST_N = ST.Replace(",", ".");
//                    label7.Text = raz;
//                    label7.Show();
                }
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
//                string query = "SELECT [Допуск, мкм] FROM [Таблица 5] WHERE ([Номинальный диаметр резьбы, мм]=" + D_1 + " and + [Шаг, мм]=" + ST_N + " and + [Степень точности]=" + CL_1 + ")";

//                OleDbCommand command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                string Td2 = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                Td2_1 = Convert.ToInt32(Td2);
            }
            catch
            {
            }
            try
            {
//                string query = "SELECT [Допуск, мкм] FROM [Таблица 6] WHERE ([Номинальный диаметр резьбы, мм]=" + D_1 + " and + [Шаг, мм]=" + ST_N + " and + [Степень точности]=" + CL_1 + ")";

//                OleDbCommand command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                string TD2 = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                TD2_1 = Convert.ToInt32(TD2);
            }
            catch
            {
            }
            try
            {
                var ST_N = "1";
                var OO1_1 = 'd';
                string query = "SELECT [Отклонение в мкм] FROM [Таблица 7] WHERE ([Шаг]=" + ST_N + " and + [Буквенное обозначение основных отклонений]=" + OO1_1 + ")";

                OleDbCommand command = new OleDbCommand(query, myConnection);
#pragma warning disable CS8602
                string EI = command.ExecuteScalar().ToString();
#pragma warning disable CS8602
                EI_1 = Convert.ToInt32(EI);
            }
            catch
            {
                //textBox4.Text = Convert.ToString(344);
            }
            try
            {
//                string query = "SELECT [Отклонение в мкм] FROM [Таблица 7] WHERE ([Шаг]=" + ST_N + " and + [Буквенное обозначение основных отклонений]=" + OO2_2 + ")";

//                OleDbCommand command = new OleDbCommand(query, myConnection);
//#pragma warning disable CS8602
//                string es = command.ExecuteScalar().ToString();
//#pragma warning disable CS8602
//                es_1 = Convert.ToInt32(es);
            }
            catch
            {
            }

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = pictureBox1.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 293 - TD2_1, 100, TD2_1)); //внеш
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 293, 400, 2));
            myPen.Dispose();
            formGraphics.Dispose();
            textBox3.Text = Convert.ToString(es_1);
            textBox4.Text = Convert.ToString(EI_1);
        }
       
    }
}
