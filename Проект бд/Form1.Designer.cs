namespace Проект_бд
{
    partial class Form1: System.Windows.Forms.Form
    {
        //private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2.0.mdb";
        private System.ComponentModel.Container components;
        private System.Windows.Forms.TabPage tabPage1, tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label box1Label1, box1Label2, box1Label3, box1Label4, 
        box3Label1, box3Label2, box3Label3, box3Label4, box3Label5, box3Label6, 
        box4Label1, box4Label2, box4Label3, box4Label4, box4Label5, box4Label6, box4Label7, box4Label8, 
        box4Label9, box4Label10, box4Label11, box4Label12, box4Label13, box4Label14, box4Label15, box4Label16;
        private System.Windows.Forms.TextBox box1TextBox1, box1TextBox2, box1TextBox3, box3TextBox1, box3TextBox2, box3TextBox3,
        box4TextBox1, box4TextBox2, box4TextBox3, box4TextBox4, box4TextBox5, box4TextBox6, box4TextBox7;
        private System.Windows.Forms.ComboBox box1ComboBox1, box4ComboBox2;
        private System.Windows.Forms.CheckBox box1CheckBox1, box4CheckBox1;
        private System.Windows.Forms.GroupBox groupBox1, groupBox2, groupBox3, groupBox4;
        private System.Windows.Forms.Button box1Button1, box2Button1;
        private System.Windows.Forms.PictureBox box4Pic1;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();

            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.box1Label1 = new System.Windows.Forms.Label();
            this.box1Label2 = new System.Windows.Forms.Label();
            this.box1Label3 = new System.Windows.Forms.Label();
            this.box1Label4 = new System.Windows.Forms.Label();
            this.box3Label1 = new System.Windows.Forms.Label();
            this.box3Label2 = new System.Windows.Forms.Label();
            this.box3Label3 = new System.Windows.Forms.Label();
            this.box3Label4 = new System.Windows.Forms.Label();
            this.box3Label5 = new System.Windows.Forms.Label();
            this.box3Label6 = new System.Windows.Forms.Label();
            this.box4Label1 = new System.Windows.Forms.Label();
            this.box4Label2 = new System.Windows.Forms.Label();
            this.box4Label3 = new System.Windows.Forms.Label();
            this.box4Label4 = new System.Windows.Forms.Label();
            this.box4Label5 = new System.Windows.Forms.Label();
            this.box4Label6 = new System.Windows.Forms.Label();
            this.box4Label7 = new System.Windows.Forms.Label();
            this.box4Label8 = new System.Windows.Forms.Label();
            this.box4Label9 = new System.Windows.Forms.Label();
            this.box4Label10 = new System.Windows.Forms.Label();
            this.box4Label11 = new System.Windows.Forms.Label();
            this.box4Label12 = new System.Windows.Forms.Label();
            this.box4Label13 = new System.Windows.Forms.Label();
            this.box4Label14 = new System.Windows.Forms.Label();
            this.box4Label15 = new System.Windows.Forms.Label();
            this.box4Label16 = new System.Windows.Forms.Label();
            
            this.box1TextBox1 = new System.Windows.Forms.TextBox();
            this.box1TextBox2 = new System.Windows.Forms.TextBox();
            this.box1TextBox3 = new System.Windows.Forms.TextBox();
            this.box3TextBox1 = new System.Windows.Forms.TextBox();
            this.box3TextBox2 = new System.Windows.Forms.TextBox();
            this.box3TextBox3 = new System.Windows.Forms.TextBox();
            this.box4TextBox1 = new System.Windows.Forms.TextBox();
            this.box4TextBox2 = new System.Windows.Forms.TextBox();
            this.box4TextBox3 = new System.Windows.Forms.TextBox();
            this.box4TextBox4 = new System.Windows.Forms.TextBox();
            this.box4TextBox5 = new System.Windows.Forms.TextBox();
            this.box4TextBox6 = new System.Windows.Forms.TextBox();
            this.box4TextBox7 = new System.Windows.Forms.TextBox();

            this.box1ComboBox1 = new System.Windows.Forms.ComboBox();
            this.box4ComboBox2 = new System.Windows.Forms.ComboBox();

            this.box1CheckBox1 = new System.Windows.Forms.CheckBox();
            this.box4CheckBox1 = new System.Windows.Forms.CheckBox();

            this.box1Button1 = new System.Windows.Forms.Button();
            this.box2Button1 = new System.Windows.Forms.Button();

            this.box4Pic1 = new System.Windows.Forms.PictureBox();
            
            ///
            ///ISO 898-1 BEGIN
            ///

            ///BOX1----------------------------------BOX1
            //Labels
            //box1Label1 Резьба, D:
            box1Label1.Location = new System.Drawing.Point(56,32);
            box1Label1.Text = "Резьба, d:";
            box1Label1.Size = new System.Drawing.Size(70,16);
            box1Label1.TabIndex = 1;
            //box1Label2 Шаг:
            box1Label2.Location = new System.Drawing.Point (84,0);
            box1Label2.Top = box1Label1.Top + 30;
            box1Label2.Text = "Шаг:";
            box1Label2.Size = new System.Drawing.Size (36,16);
            box1Label2.TabIndex = 2;
            //box1Label3 Класс прочности:
            box1Label4.Location = new System.Drawing.Point (11,0);
            box1Label4.Top = box1Label2.Top + 30;
            box1Label4.Text = "Класс прочности:";
            box1Label4.Size = new System.Drawing.Size (109,16);
            box1Label4.TabIndex = 2;
            //TextBoxes
            //
            //box1TextBox1 D
            box1TextBox1.Left = box1Label1.Left + box1Label1.Width;
            box1TextBox1.Top = box1Label1.Top - 5;
            box1TextBox1.Size = new System.Drawing.Size(70,20);
            box1TextBox1.TabIndex = 1;
            //box1TextBox3 Strenght
            box1TextBox3.Left = box1TextBox1.Left; 
            box1TextBox3.Top = box1Label4.Top - 5;
            box1TextBox3.Size = new System.Drawing.Size(70,20);
            box1TextBox3.TabIndex = 4;
            //
            //Buttons
            //box1Button1 Поясняющая кнопка
            box1Button1.Top = box1Label4.Top - 5;
            box1Button1.Left = box1TextBox3.Left + box1TextBox3.Width + 5;
            box1Button1.Size = new System.Drawing.Size(30,25);
            box1Button1.Image = Image.FromFile("Quest.png");
            box1Button1.TabIndex = 4;
            //
            //CheckBoxes
            //CheckBox1 Мелкий шаг
            box1CheckBox1.Left = box1Label1.Left + box1Label1.Width + box1TextBox1.Width + 5;
            box1CheckBox1.Top = box1Label1.Top;
            box1CheckBox1.Text = "Мелкий шаг";
            box1CheckBox1.Size = new System.Drawing.Size(96,16);
            box1CheckBox1.TabIndex = 1;
            box1CheckBox1.Visible = true;
            //
            //ComboBoxes
            //box1ComboBox1 Step
            box1ComboBox1.Left = box1TextBox1.Left; 
            box1ComboBox1.Top = box1Label2.Top - 5;
            box1ComboBox1.Size = new System.Drawing.Size(70,20);
            box1ComboBox1.TabIndex = 2;
            //
            ///BOX2----------------------------------BOX2
            //Buttons
            //box2Button1 Кнопка расчета
            box2Button1.Left = 15;
            box2Button1.Top = box1TextBox1.Top - 5;
            box2Button1.TextAlign = ContentAlignment.MiddleCenter;
            box2Button1.Text = "Выполнить";
            box2Button1.Size = new System.Drawing.Size(295,25);
            box1Button1.TabIndex = 5;
            //
            ///BOX3----------------------------------BOX3
            //Labels
            //box3Label1 Площадь сечения резьбы As,nom:
            box3Label1.Location = new System.Drawing.Point(15,36);
            box3Label1.Text = "Площадь сечения резьбы As, nom:";
            box3Label1.Size = new System.Drawing.Size(200,16);
            box3Label1.TabIndex = 1;
            //box3Label3 Пробная нагрузка, Fp:
            box3Label3.Left = box3Label1.Left + 70;
            box3Label3.Top = box3Label1.Top + 30;
            box3Label3.Text = "Пробная нагрузка, Fp:";
            box3Label3.Size = new System.Drawing.Size(130,16);
            box3Label3.TabIndex = 1;
            //box3Label5 Разрушающая нагрузка, Fm,min:
            box3Label5.Left = box3Label1.Left + 8;
            box3Label5.Top = box3Label3.Top + 30;
            box3Label5.Text = "Разрушающая нагрузка, Fm, min:";
            box3Label5.Size = new System.Drawing.Size(192,16);
            box3Label5.TabIndex = 1;
            //
            //TextBoxes
            //box3TextBox1
            box3TextBox1.Left = box3Label1.Left + box3Label1.Width;
            box3TextBox1.Top = box3Label1.Top - 5;
            box3TextBox1.Size = new System.Drawing.Size(70, 20);
            box3TextBox1.TabIndex = 5;
            //box3TextBox2
            box3TextBox2.Left = box3TextBox1.Left;
            box3TextBox2.Top = box3Label3.Top - 5;
            box3TextBox2.Size = new System.Drawing.Size(70, 20);
            box3TextBox2.TabIndex = 6;
            //box3TextBox3
            box3TextBox3.Left = box3TextBox1.Left;
            box3TextBox3.Top = box3Label5.Top - 5;
            box3TextBox3.Size = new System.Drawing.Size(70, 20);
            box3TextBox3.TabIndex = 7;
            //Labels
            //box3Label2 мм2
            box3Label2.Left = box3TextBox1.Left + box3TextBox1.Width;
            box3Label2.Top = box3Label1.Top;
            box3Label2.Text = "мм2";
            box3Label2.Size = new System.Drawing.Size(32,16);
            box3Label2.TabIndex = 1;
            //box3Label4 Н
            box3Label4.Left = box3TextBox2.Left + box3TextBox2.Width;
            box3Label4.Top = box3Label3.Top;
            box3Label4.Text = "Н";
            box3Label4.Size = new System.Drawing.Size(16,16);
            box3Label4.TabIndex = 1;
            //box3Label6 Н
            box3Label6.Left = box3TextBox3.Left + box3TextBox3.Width;
            box3Label6.Top = box3Label5.Top;
            box3Label6.Text = "Н";
            box3Label6.Size = new System.Drawing.Size(16,16);
            box3Label6.TabIndex = 1;
            ///BOX4----------------------------------BOX4
            //Labels
            //box4Label1 Изделие
            box4Label1.Location = new System.Drawing.Point(90,32);
            box4Label1.Text = "Изделие:";
            box4Label1.Size = new System.Drawing.Size(60,16);
            box4Label1.TabIndex = 1;
            //ComboBoxes Product
            box4ComboBox2.Top = box4Label1.Top;
            box4ComboBox2.Left = box4Label1.Right;
            box4ComboBox2.Items.AddRange(new object[4]{"Шпилька", "Болт", "Гайка", "Шайба"});
            box4ComboBox2.Text = "Выберите из списка";
            //box1Label3 Длина резьбы:
            box1Label3.Left = box4ComboBox2.Right - 70 - 105;
            box1Label3.Top = box4Label1.Top + 35;
            box1Label3.Text = "Длина резьбы l1:";
            box1Label3.Size = new System.Drawing.Size (105,16);
            box1Label3.TabIndex = 2;
            //box1TextBox2 Длина резьбы
            box1TextBox2.Left = box4ComboBox2.Right - 70; 
            box1TextBox2.Top = box1Label3.Top - 5;
            box1TextBox2.Size = new System.Drawing.Size(70,20);
            box1TextBox2.TabIndex = 3;
            //box4Label8 мм
            box4Label8.Left = box1TextBox2.Left + box1TextBox2.Width;
            box4Label8.Top = box1Label3.Top;
            box4Label8.Text = "мм";
            box4Label8.Size = new System.Drawing.Size(32,16);
            box4Label8.TabIndex = 1;
            //box4CheckBox1 
            box4CheckBox1.Left = box4ComboBox2.Right - 135;
            box4CheckBox1.Top = box1Label3.Top + 30;
            box4CheckBox1.Text = "Резьба с двух сторон";
            box4CheckBox1.Size = new System.Drawing.Size(160,20);
            box4CheckBox1.TabIndex = 1;
            box4CheckBox1.Visible = true;
            //box4Label2 Длина резьбы второго участка
            box4Label2.Left = box4ComboBox2.Right - 70 - 105;
            box4Label2.Top = box4CheckBox1.Top + 30;
            box4Label2.Text = "Длина резьбы l2:";
            box4Label2.Size = new System.Drawing.Size(105,20);
            //box4TextBox1
            box4TextBox1.Left = box4ComboBox2.Right - 70;
            box4TextBox1.Top = box4Label2.Top - 5;
            box4TextBox1.Size = new System.Drawing.Size(70,20);
            //box4Label9 мм
            box4Label9.Left = box4TextBox1.Left + box4TextBox1.Width;
            box4Label9.Top = box4Label2.Top;
            box4Label9.Text = "мм";
            box4Label9.Size = new System.Drawing.Size(32,16);
            box4Label9.TabIndex = 1;
            //box4Label3 Длина шпильки
            box4Label3.Left = box4ComboBox2.Right - 70 - 115;
            box4Label3.Top = box4Label2.Top + 30;
            box4Label3.Text = "Длина шпильки L:";
            box4Label3.Size = new System.Drawing.Size(115,20);
            //box4TextBox2
            box4TextBox2.Left = box4ComboBox2.Right - 70;
            box4TextBox2.Top = box4Label3.Top - 5;
            box4TextBox2.Size = new System.Drawing.Size(70,20);
            //box4Label10 мм
            box4Label10.Left = box4TextBox2.Left + box4TextBox2.Width;
            box4Label10.Top = box4Label3.Top;
            box4Label10.Text = "мм";
            box4Label10.Size = new System.Drawing.Size(32,16);
            box4Label10.TabIndex = 1;
            //box4Image
            box4Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            box4Pic1.Image = Image.FromFile("Image/Sh1.jpg");
            box4Pic1.Location = new System.Drawing.Point(5,400-145-5);
            box4Pic1.Size = new System.Drawing.Size(310,145);
            //box4Label15 Площадь поверхности резьбы, Sпов:
            box4Label15.Left = box4ComboBox2.Right - 70 - 150;
            box4Label15.Top = box4Label3.Top + 30;
            box4Label15.Text = "Площадь поверхности А:";
            box4Label15.Size = new System.Drawing.Size(150,16);
            box4Label15.TabIndex = 8;
            //box3TextBox4
            box4TextBox7.Left = box4ComboBox2.Right - 70;
            box4TextBox7.Top = box4Label15.Top - 5;
            box4TextBox7.Size = new System.Drawing.Size(70, 20);
            box4TextBox7.TabIndex = 8;
            //box4Label6 мм2
            box4Label16.Left = box4TextBox7.Left + box4TextBox7.Width;
            box4Label16.Top = box4Label15.Top;
            box4Label16.Text = "мм2";
            box4Label16.Size = new System.Drawing.Size(32,16);
            box4Label16.TabIndex = 1;
            //box4Label4 Площадь полной поверхности
            box4Label4.Left = box4ComboBox2.Right - 70 - 180;
            box4Label4.Top = box4Label15.Top + 30;
            box4Label4.Text = "Площадь поверхности резьбы:";
            box4Label4.Size = new System.Drawing.Size(180,20);
            //box4TextBox3
            box4TextBox3.Left = box4ComboBox2.Right - 70;
            box4TextBox3.Top = box4Label4.Top - 5;
            box4TextBox3.Size = new System.Drawing.Size(70,20);
            //box4Label11 мм2
            box4Label11.Left = box4TextBox3.Left + box4TextBox3.Width;
            box4Label11.Top = box4Label4.Top;
            box4Label11.Text = "мм2";
            box4Label11.Size = new System.Drawing.Size(32,16);
            box4Label11.TabIndex = 1;
            //box4Label5 Внутренний диаметр d1:
            box4Label5.Left = box4ComboBox2.Right - 70 - 145;
            box4Label5.Top = box4ComboBox2.Top + 35;
            box4Label5.Text = "Внутренний диаметр d1:";
            box4Label5.Size = new System.Drawing.Size(145,20);
            //box4Label6 Внешний диаметр d2:
            box4Label6.Left = box4Label5.Right - 132;
            box4Label6.Top = box4Label5.Top + 30;
            box4Label6.Text = "Внешний диаметр d2:";
            box4Label6.Size = new System.Drawing.Size(132,20);
            //box4Label7 Толщина S:
            box4Label7.Left = box4Label6.Right - 75;
            box4Label7.Top = box4Label6.Top + 30;
            box4Label7.Text = "Толщина S:";
            box4Label7.Size = new System.Drawing.Size(75,20);
            //box4TextBox4
            box4TextBox4.Left = box4ComboBox2.Right - 70;
            box4TextBox4.Top = box4Label5.Top - 5;
            box4TextBox4.Size = new System.Drawing.Size(70,20);
            //box4TextBox5
            box4TextBox5.Left = box4ComboBox2.Right - 70;
            box4TextBox5.Top = box4Label6.Top - 5;
            box4TextBox5.Size = new System.Drawing.Size(70,20);
            //box4TextBox6
            box4TextBox6.Left = box4ComboBox2.Right - 70;
            box4TextBox6.Top = box4Label7.Top - 5;
            box4TextBox6.Size = new System.Drawing.Size(70,20);
            //box4Label12 мм2
            box4Label12.Left = box4TextBox4.Left + box4TextBox4.Width;
            box4Label12.Top = box4Label5.Top;
            box4Label12.Text = "мм";
            box4Label12.Size = new System.Drawing.Size(32,16);
            box4Label12.TabIndex = 1;
            //box4Label13 мм2
            box4Label13.Left = box4TextBox5.Left + box4TextBox5.Width;
            box4Label13.Top = box4Label6.Top;
            box4Label13.Text = "мм";
            box4Label13.Size = new System.Drawing.Size(32,16);
            box4Label13.TabIndex = 1;
            //box4Label14 мм2
            box4Label14.Left = box4TextBox6.Left + box4TextBox6.Width;
            box4Label14.Top = box4Label7.Top;
            box4Label14.Text = "мм";
            box4Label14.Size = new System.Drawing.Size(32,16);
            box4Label14.TabIndex = 1;
            
            
            //box4ComboBox1 Object
            ///
            ///ISO 898-1 END
            ///
            ///
            ///ISO 898-2 BEGIN
            ///
            tabPage2.Text = "ГОСТ ISO 898-2";
            tabPage2.Size = new System.Drawing.Size(640, 360);
            tabPage2.TabIndex = 1;
            this.Text = "Form1";
            ///
            ///ISO 898-2 END
            ///
            //ADDS
            //add the TabControl to the form
            this.Controls.Add(this.tabControl1);
            //add the tab pages to the TabControl
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            //add to tab1 ГОСТ ISO 898-1
            tabPage1.Controls.Add(this.groupBox1);
            tabPage1.Controls.Add(this.groupBox2);
            tabPage1.Controls.Add(this.groupBox3);
            tabPage1.Controls.Add(this.groupBox4);
            //add to groupBox1
            groupBox1.Controls.Add(this.box1Label1);
            //groupBox1.Controls.Add(this.box1Label3);
            groupBox1.Controls.Add(this.box1Label4);
            groupBox1.Controls.Add(this.box1TextBox1);
            //groupBox1.Controls.Add(this.box1TextBox2);
            groupBox1.Controls.Add(this.box1TextBox3);
            groupBox1.Controls.Add(this.box1CheckBox1);
            groupBox1.Controls.Add(this.box1Button1);
            //add to groupBox2
            groupBox2.Controls.Add(this.box2Button1);
            //add to groupBox3
            groupBox3.Controls.Add(this.box3Label1);
            groupBox3.Controls.Add(this.box3Label2);
            groupBox3.Controls.Add(this.box3Label3);
            groupBox3.Controls.Add(this.box3Label4);
            groupBox3.Controls.Add(this.box3Label5);
            groupBox3.Controls.Add(this.box3Label6);
            groupBox3.Controls.Add(this.box3TextBox1);
            groupBox3.Controls.Add(this.box3TextBox2);
            groupBox3.Controls.Add(this.box3TextBox3);
            //add to groupBox4
            groupBox4.Controls.Add(this.box4ComboBox2);
            groupBox4.Controls.Add(this.box4Label1);
            //
            //Form1
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            //TabControl
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Size = new System.Drawing.Size(670,450);
            tabControl1.SelectedIndex = 0;
            tabControl1.TabIndex = 0;
            //
            //tabPage1
            tabPage1.Text = "ГОСТ ISO 898-1";
            tabPage1.Size = new System.Drawing.Size(670, 416);
            tabPage1.TabIndex = 0;
            //
            //groupBox1
            groupBox1.Location = new System.Drawing.Point(10,10);
            groupBox1.Text = "Исходные данные";
            groupBox1.Size = new System.Drawing.Size (325,150);
            //groupBox2
            groupBox2.Left = groupBox1.Left;
            groupBox2.Top = groupBox1.Top + groupBox1.Height + 10;
            groupBox2.Text = "Расчет";
            groupBox2.Size = new System.Drawing.Size (325,60);
            //groupBox3
            groupBox3.Left = groupBox1.Left;
            groupBox3.Top = groupBox2.Top + groupBox2.Height + 10;
            groupBox3.Text = "Результаты расчета";
            groupBox3.Size = new System.Drawing.Size (325,170);
            //groupBox4
            groupBox4.Top = groupBox1.Top;
            groupBox4.Left = groupBox1.Size.Width + 20;
            groupBox4.Text = "Расчет площади поверхности";
            groupBox4.Size = new System.Drawing.Size(325, 400);
            //
            //EVENTS
            box1CheckBox1.Click += new EventHandler(box1CheckBox1_Click);
            box1Button1.Click += new EventHandler(box1Button1_Click);
            box2Button1.Click += new EventHandler(box2Button1_Click);
            box1TextBox1.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1TextBox1.Leave += new EventHandler(box1TextBox1_Leave);
            box1TextBox2.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1TextBox3.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1ComboBox1.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box4ComboBox2.SelectedValueChanged += new EventHandler(box4ComboBox2_SelectedValueChanged);
            box4CheckBox1.Click += new EventHandler(box4CheckBox1_Click);
        }

    }
      #endregion
}