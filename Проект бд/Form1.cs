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
        private void  box1Button1_Click (object sender, System.EventArgs e)//Нажатие на кнопку вопроса
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
        private void box1CheckBox1_Click(object sender, System.EventArgs e){//Проверка отметки на чекбоксе "Мелкий шаг"
            if(box1CheckBox1.Checked)
            {
            groupBox1.Controls.Add(this.box1Label2);
            groupBox1.Controls.Add(this.box1ComboBox1);
            }
            else
            {
            groupBox1.Controls.Remove(this.box1Label2);
            groupBox1.Controls.Remove(this.box1ComboBox1);
            }
        }
        private void box4CheckBox1_Click(object sender, System.EventArgs e){//При клике на чекбокс в 4 боксе "Резьба с двух сторон"
            if(box4CheckBox1.Checked){
                groupBox4.Controls.Add(this.box4TextBox2);
                groupBox4.Controls.Add(this.box4Label3);
                groupBox4.Controls.Add(this.box4Label2);
                groupBox4.Controls.Add(this.box4TextBox1);
                groupBox4.Controls.Add(this.box4Label9);
                groupBox4.Controls.Add(this.box4Label10);
                box4Pic1.Image = Image.FromFile("Image/Sh2.jpg");
            }
            else
            {
                groupBox4.Controls.Remove(this.box4TextBox2);
                groupBox4.Controls.Remove(this.box4Label3);
                groupBox4.Controls.Remove(this.box4Label2);
                groupBox4.Controls.Remove(this.box4TextBox1);
                groupBox4.Controls.Remove(this.box4Label9);
                groupBox4.Controls.Remove(this.box4Label10);
                box4Pic1.Image = Image.FromFile("Image/Sh1.jpg");
            }
        }
        private void bradInit()//Инициализация интерфейса для шпильки
        {
                box4Pic1.Size = new System.Drawing.Size(310,145);
                box4Pic1.Location = new System.Drawing.Point(5,400-145-5);
                groupBox4.Controls.Add(this.box1Label3);
                groupBox4.Controls.Add(this.box1TextBox2);
                groupBox4.Controls.Add(this.box4CheckBox1);
                groupBox4.Controls.Add(this.box4Pic1);
                groupBox4.Controls.Add(this.box4Label15);
                groupBox4.Controls.Add(this.box4TextBox7);
                groupBox4.Controls.Add(this.box4Label16);
                groupBox4.Controls.Add(this.box4Label4);
                groupBox4.Controls.Add(this.box4Label8);
                groupBox4.Controls.Add(this.box4Label11);
                groupBox4.Controls.Add(this.box4TextBox3);
                if(box4CheckBox1.Checked){
                    groupBox4.Controls.Add(this.box4TextBox2);
                    groupBox4.Controls.Add(this.box4Label3);
                    groupBox4.Controls.Add(this.box4Label2);
                    groupBox4.Controls.Add(this.box4TextBox1);
                    groupBox4.Controls.Add(this.box4Label9);
                    groupBox4.Controls.Add(this.box4Label10);
                box4Pic1.Image = Image.FromFile("Image/Sh2.jpg");
                }else{
                    groupBox4.Controls.Remove(this.box4TextBox2);
                    groupBox4.Controls.Remove(this.box4Label3);
                    groupBox4.Controls.Remove(this.box4Label2);
                    groupBox4.Controls.Remove(this.box4TextBox1);
                    groupBox4.Controls.Remove(this.box4Label9);
                    groupBox4.Controls.Remove(this.box4Label10);
                    box4Pic1.Image = Image.FromFile("Image/Sh1.jpg"); 
                }
        }
        private void box4ComboBox2_SelectedValueChanged(object sender, System.EventArgs e){//Отображение интерфейса для бокс4
            try{
                string t = box4ComboBox2.Text;
                groupBox4.Controls.Clear();
                groupBox4.Controls.Add(this.box4Label1);
                groupBox4.Controls.Add(this.box4ComboBox2);
                box4ComboBox2.Text = t;
            switch(Convert.ToByte(box4ComboBox2.SelectedIndex))
            {
                case 0: //Шпилька
                bradInit();
                break;
                case 1://Болт
                groupBox4.Controls.Add(this.box1Label3);
                groupBox4.Controls.Add(this.box1TextBox2);
                break;
                case 2://Гайка
                break;
                case 3://Шайба
                box4Pic1.Location = new System.Drawing.Point(5,400-180-5);
                box4Pic1.Size = new System.Drawing.Size(310,180);
                groupBox4.Controls.Add(this.box4Label5);
                groupBox4.Controls.Add(this.box4Label6);
                groupBox4.Controls.Add(this.box4Label7);
                groupBox4.Controls.Add(this.box4TextBox4);
                groupBox4.Controls.Add(this.box4TextBox5);
                groupBox4.Controls.Add(this.box4TextBox6);
                groupBox4.Controls.Add(this.box4Label12);
                groupBox4.Controls.Add(this.box4Label13);
                groupBox4.Controls.Add(this.box4Label14);
                groupBox4.Controls.Add(this.box4Label15);
                groupBox4.Controls.Add(this.box4Label16);
                groupBox4.Controls.Add(this.box4TextBox7);
                groupBox4.Controls.Add(this.box4Pic1);
                box4Pic1.Image = Image.FromFile("Image/Sha.jpg");
                break;

            }
            }
            catch
            {

            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)// При закрытии формы 1, закрывать субд
        {
            Rezba.Close();
            TwoZero.Close();
            Diameters.Close();
        }
        private void washerCalc(){//Расчет шайбы
            double d1 = Convert.ToDouble(box4TextBox4.Text);
            double d2 = Convert.ToDouble(box4TextBox5.Text);
            double S = Convert.ToDouble(box4TextBox6.Text);
            double ss = Math.Pow(d2/2,2)*Math.PI - Math.Pow(d1/2,2)*Math.PI ;
            double sp = ss*2 + Math.PI*d1*S + Math.PI*d2*S; 
            box4TextBox7.Text = sp.ToString();
        }
        private void box2Button1_Click(object sender, EventArgs e)//    При нажатии на кнопку 1 - Выполнить, происходит рассчет
        {
            try
            {
                switch(Convert.ToByte(box4ComboBox2.SelectedIndex)){
                    case 0://Шпилька
                    break;
                    case 1://Болт
                    break;
                    case 2://Гайка
                    break;
                    case 3://Шайба
                    
                    break;
                }
            }
            catch
            {

            }
            string query;
            OleDbCommand command;
            string Step = "";
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
            string lRezb = box1TextBox2.Text;
            string lRezb2 = box4TextBox1.Text;
            string lShp = box4TextBox2.Text;
            string As = box3TextBox1.Text;
            string Fp = box3TextBox2.Text;
            string Fm = box3TextBox3.Text;
            string SPov = box4TextBox7.Text;

            D = sZ(D);
            Str = sZ(Str);
            As = sZ(As);
            Fp = sZ(Fp);
            Fm = sZ(Fm);
            SPov = sZ(SPov);
            lRezb = sZ(lRezb);
            lRezb2 = sZ(lRezb2);
            lShp = sZ(lShp);

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
            double l1 = 0;
            double l2 = 0;
            double lSp = 0;
            double H = 0;

            try
            {
            d_ = Convert.ToDouble(D);//Номинальный диаметр
            s_ = Convert.ToDouble(Step);//Шаг резьбы
            l1 = Convert.ToDouble(lRezb);//Длина резьбы
            l2 = Convert.ToDouble(lRezb2);//Длина резьбы второго участка
            lSp = Convert.ToDouble(lShp);//Длина шпильки
            H = 0.866025404 * s_ * (Math.Cos(30*Math.PI/180));//Высота исходного треугольника по ГОСТ 9150-2002
            }
            catch
            {

            }
            try{
            switch(Convert.ToByte(box4ComboBox2.SelectedIndex))
            {
                case 0:
                try //Расчет площади полной поверхности резьбы
                {
                    if(box4CheckBox1.Checked)
                    {
                        L1 = Math.Sqrt(Math.Pow(Math.PI*d_,2)+Math.Pow(s_,2));//Длина одного витка линии по Учебному пособию 1, с 6
                        L = ((l1 + l2) / s_) * L1;//Длина резьбы 1+2
                        double sp_ = H * L * 2;//Площадь поверхности резьбы
                        box4TextBox3.Text = sp_.ToString();
                        sp_ += lSp / s_ * L1;//Площадь поверхности без учета торцев
                        sp_ += 2 * Convert.ToDouble(As);//Площадь поверхности с учетом торцев
                        SPov = sp_.ToString();
                    }
                    else
                    {
                        L1 = Math.Sqrt(Math.Pow(Math.PI*d_,2)+Math.Pow(s_,2));//Длина одного витка линии по Учебному пособию 1, с 6
                        L = (l1 / s_) * L1;//Длина всей спирали
                        double sp_ = H * L * 2;//Площадь поверхности
                        box4TextBox3.Text = sp_.ToString();
                        sp_ += 2 * Convert.ToDouble(As);//Площадь повеxрхности с учетом торцев
                        SPov = sp_.ToString();
                    }
                }
                catch
                {
                }
                break;
                case 1:
                break;
                case 2:
                break;
                case 3:
                washerCalc();
                break;
            }
            }
            catch{}
            //Значение площади сечения
            box3TextBox1.Text = As;
            //Значение пробной нагрузки
            box3TextBox2.Text = Fp;
            //Значение разрушающей нагрузки
            box3TextBox3.Text = Fm;
            //Значение полной площади поверхности резьбы
            if(d_> 0 && l1 > 0 && s_ > 0 && Convert.ToByte(box4ComboBox2.SelectedIndex) == 0)
            {
                box4TextBox7.Text = SPov;
            }
            else
            {
                //box3TextBox4.Text = '0'.ToString();
            }
        }
    
    }
}