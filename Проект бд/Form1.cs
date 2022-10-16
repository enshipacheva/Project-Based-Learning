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
       public string connectStringRezba = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rezba.mdb";
       public static string connectStringTwoZero = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2.0.mdb";
       public static string connectStringDiameters = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Diameters2.mdb";
        private OleDbConnection Rezba, TwoZero, Diameters;
        
        public Form1()
        {
            InitializeComponent();
            Rezba = new OleDbConnection(connectStringRezba);
            TwoZero = new OleDbConnection(connectStringTwoZero);
            Diameters = new OleDbConnection(connectStringDiameters);
            Rezba.Open();
            TwoZero.Open();
            Diameters.Open();
        }
        private void  box1Button1_Click (object sender, System.EventArgs e)
        {
            //const string message = ;
            MessageBox.Show("ГОСТ ISO 898-1-2014" +
                "\n\nСимвол класса прочности для болтов, винтов и шпилек состоит из двух чисел, разделенных точкой" +
            "\n\na) число с левой стороны от точки состоит из одной или двух цифр и означает 1/100 от номинального предела прочности  в мегапаскалях;" +
            "\n\nb) число с правой стороны от точки равняется умноженному на 10 отношению номинального значения предела текучести к номинальному значению предела прочности на растяжение." +
            "\n\nПример 1\nКрепежное изделие с номинальным пределом прочности на растяжение R=800 МПа и коэффициентом предела текучести, равным 0,8, обозначается классом прочности 8.8." +
            "\n\nПример 2\nКрепежное изделие со свойствами материала класса прочности 8.8, но с уменьшенной нагрузочной способностью обозначается классом прочности 08.8.");
        }
        private void box1TextBox1_Leave(object sender, EventArgs e)//  При выходе из ячейки Диаметра, создается список шагов в ячейке Шаг
        {  
            box1ComboBox1.Items.Clear();
            try
            {
                OleDbCommand command;
                double D = Convert.ToDouble(box1TextBox1.Text);
                string query = "SELECT [num] FROM [Table1] WHERE [Dnom] = \"" + D + "\"";
                command =  new OleDbCommand(query, Diameters);
                int j = Convert.ToInt32(command.ExecuteScalar().ToString());
                j++;
                while(j != 0)
                {
                    query = "SELECT [Dnom] FROM [Table1] WHERE [num] = " + j;
                    command =  new OleDbCommand(query, Diameters);
                    if(Convert.ToDouble(command.ExecuteScalar().ToString()) == D)
                    {
                        query = "SELECT [Step] FROM [Table1] WHERE [num] = " + j;
                        command =  new OleDbCommand(query, Diameters);
                        double s = Convert.ToDouble(command.ExecuteScalar().ToString());
                        box1ComboBox1.Items.Add(s);
                        j++;
                    }
                    else
                    {
                        j = 0;
                    }
                }
            }
            catch
            {

            }
        }
        private void box1TextBox1_KeyPress(object sender, KeyPressEventArgs e)//    Разрешить ввод в ячейку Диаметр только цифр , . backspace
        {
            if(Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(box1TextBox1.Text) && (e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == (char)8)))
            {
                return;
            }
            e.Handled = true;
        }
        private void box1CheckBox1_Click(object sender, System.EventArgs e){
            if(box1CheckBox1.Checked){
            groupBox1.Controls.Add(this.box1Label2);
            groupBox1.Controls.Add(this.box1ComboBox1);
            }
            if(!box1CheckBox1.Checked){
            groupBox1.Controls.Remove(this.box1Label2);
            groupBox1.Controls.Remove(this.box1ComboBox1);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// При закрытии формы 1, закрывать субд
        {
            Rezba.Close();
            TwoZero.Close();
            Diameters.Close();
        }
        private void box2Button1_Click(object sender, EventArgs e)//    При нажатии на кнопку 1 - Выполнить, происходит рассчет
        {
            string query;
            OleDbCommand command;
            string Step = ""    ;
            string D = box1TextBox1.Text;
            bool smallStep = box1CheckBox1.Checked;
            if(smallStep){
                Step = box1ComboBox1.Text;
            }
            else
            {
                try
                {
                    query = "SELECT [num] FROM [Table1] WHERE [Dnom] = \"" + D + "\"";
                    command =  new OleDbCommand(query, Diameters);
                    int j = Convert.ToInt32(command.ExecuteScalar().ToString());
                    query = "SELECT [Step] FROM [Table1] WHERE [num] = " + j;
                    command =  new OleDbCommand(query, Diameters);
                    string f = command.ExecuteScalar().ToString();
                    double d3_ = Convert.ToDouble(f);
                    Step = d3_.ToString();
                }
                catch
                {

                }
            }
            string Str = box1TextBox3.Text;
            string LRezb = box1TextBox2.Text;
            string As = box3TextBox1.Text;
            string Fp = box3TextBox2.Text;
            string Fm = box3TextBox3.Text;
            string SPov = box3TextBox4.Text;

            D = sZ(D);
            Str = sZ(Str);
            As = sZ(As);
            Fp = sZ(Fp);
            Fm = sZ(Fm);
            SPov = sZ(SPov);
            LRezb = sZ(LRezb);

            string sZ(string o){
                if(o == ""){
                    o = "0";
                }
                return o;
            }

            try //Расчет площади сечения резьбы в мм2
            {
                //Рассчетная площадь сечения по ГОСТ 898-1 2014
                query = "SELECT [Dbott] FROM [Table1] WHERE ([Dnom] = \"" + D + "\" and + [Step] = \"" + Step + "\")";
                command =  new OleDbCommand(query, Diameters);
                string f = command.ExecuteScalar().ToString();
                double d3_ = Convert.ToDouble(f);
                query = "SELECT [Dmid] FROM [Table1] WHERE ([Dnom] = \"" + D + "\" and + [Step] = \"" + Step + "\")";
                command = new OleDbCommand(query,Diameters);
                double d2_ = Convert.ToDouble(command.ExecuteScalar().ToString());  //Номинальный средний диаметр наружной резьбы в соответсвии с ISO 724, ГОСТ 24705-2004
                double dp_ = (d2_ + d3_) / 2;   //Номинальный внутренний диаметр наружной резьбы по дну впадины, формула в ГОСТ 898-1 2014 ПОСМОТРЕТЬ!
                double a_ = Math.Round(Math.PI * dp_ * dp_ / 4,3); 
                As = a_.ToString();
            }
            catch(System.NullReferenceException)//При пустых или некорректных значениях диаметра или резьбы - показать сообщение об ошибке
            {
                MessageBox.Show("Введите корректные значения для Диаметра и/или Шага резьбы");
            }
           catch(System.Data.OleDb.OleDbException)
            {
            }
            try //Расчет пробной и разрушающей нагрузки
            {
                //Пробная нагрузка
                if(!smallStep)  //При КРУПНОМ шаге
                {
                    query = "SELECT [Пробная нагрузка, Н] FROM [Болт(ISO 898-1) \"Пробная нагрузка\"(крупный шаг)] WHERE [Диаметр резьбы D, мм] =\"" + D + "\" and + [Класс прочности] =\"" + Str + "\"";
                    command = new OleDbCommand(query, TwoZero);
                    Fp = command.ExecuteScalar().ToString();
                } 
                else 
                {               //При МЕЛКОМ шаге
                    query = "SELECT [Пробная нагрузка, Н] FROM [Болт(ISO 898-1) \"Пробная нагрузка\"(мелкий шаг)] WHERE [Диаметр резьбы D, мм] =\"" + D + "\" and + [Шаг резьбы, мм] = \"" + Step + "\" and + [Класс прочности] =\"" + Str + "\"";
                    command = new OleDbCommand(query, TwoZero);
                    Fp = command.ExecuteScalar().ToString();
                }

                //Разрушающая нагрузка
                if(!smallStep)  //При КРУПНОМ шаге
                {
                    query = "SELECT [Мин разрушающая нагрузка, Н] FROM [Болт(ISO 898-1) Мин раз нагрузка, крупный шаг] WHERE [Диаметр резьбы D, мм] =\"" + D + "\" and + [Класс прочности] =\"" + Str + "\"";
                    command = new OleDbCommand(query, TwoZero);
                    Fm = command.ExecuteScalar().ToString();
                } 
                else
                {               //При МЕЛКОМ шаге
                    query = "SELECT [Мин разрушающая нагрузка, Н] FROM [Болт(ISO 898-1) Мин раз нагрузка, мелкий шаг] WHERE [Диаметр резьбы D, мм] =\"" + D + "\" and + [Шаг резьбы, мм] = \"" + Step + "\" and + [Класс прочности] =\"" + Str + "\"";
                    command = new OleDbCommand(query, TwoZero);
                    Fm = command.ExecuteScalar().ToString();
                }
            }
            catch
            {    
            }

            double L;//Длина спирали
            double L1;
            double d_ = 0;
            double s_ = 0;
            double l_ = 0;
            double H = 0;
            try
            {
            d_ = Convert.ToDouble(D);//Номинальный диаметр
            s_ = Convert.ToDouble(Step);//Шаг резьбы
            l_ = Convert.ToDouble(LRezb);//Длина резьбы
            H = 0.866025404 * s_ * (Math.Cos(30*Math.PI/180));//Высота исходного треугольника по ГОСТ 9150-2002
            }
            catch
            {

            }
            try //Расчет площади полной поверхности резьбы
            {
                L1 = Math.Sqrt(Math.Pow(Math.PI*d_,2)+Math.Pow(s_,2));//Длина одного витка линии по Учебному пособию 1, с 6
                L = (l_ / s_) * L1;//Длина всей спирали
                double sp_ = H * L * 2;//Площадь поверхности
                sp_ += 2 * Convert.ToDouble(As);//Площадь поверхности с учетом торцев
                SPov = sp_.ToString();
            }
            catch
            {
            }
            //Значение площади сечения
            box3TextBox1.Text = As;
            //Значение пробной нагрузки
            box3TextBox2.Text = Fp;
            //Значение разрушающей нагрузки
            box3TextBox3.Text = Fm;
            //Значение полной площади поверхности резьбы
            if(d_> 0 && l_ > 0 && s_ > 0){
            box3TextBox4.Text = SPov;
            }else{
                box3TextBox4.Text = '0'.ToString();
            }
        }
    
    }
}
