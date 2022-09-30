namespace Проект_бд
{
    partial class Form1: System.Windows.Forms.Form
    {
        //private static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=2.0.mdb";
        private System.ComponentModel.Container components;
        private System.Windows.Forms.TabPage tabPage1, tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label box1Label1, box1Label2, box1Label3, box1Label4, box3Label1, box3Label2, box3Label3, box3Label4, box3Label5, box3Label6, box3Label7, box3Label8;
        private System.Windows.Forms.TextBox box1TextBox1, box1TextBox2, box1TextBox3, box3TextBox1, box3TextBox2, box3TextBox3, box3TextBox4;
        private System.Windows.Forms.ComboBox box1ComboBox1;
        private System.Windows.Forms.CheckBox box1CheckBox1;
        private System.Windows.Forms.GroupBox groupBox1, groupBox2, groupBox3;
        private System.Windows.Forms.Button box1Button1, box2Button1;
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
            this.box3Label7 = new System.Windows.Forms.Label();
            this.box3Label8 = new System.Windows.Forms.Label();

            this.box1TextBox1 = new System.Windows.Forms.TextBox();
            this.box1TextBox2 = new System.Windows.Forms.TextBox();
            this.box1TextBox3 = new System.Windows.Forms.TextBox();
            this.box3TextBox1 = new System.Windows.Forms.TextBox();
            this.box3TextBox2 = new System.Windows.Forms.TextBox();
            this.box3TextBox3 = new System.Windows.Forms.TextBox();
            this.box3TextBox4 = new System.Windows.Forms.TextBox();

            this.box1ComboBox1 = new System.Windows.Forms.ComboBox();

            this.box1CheckBox1 = new System.Windows.Forms.CheckBox();

            this.box1Button1 = new System.Windows.Forms.Button();
            this.box2Button1 = new System.Windows.Forms.Button();
            
            ///
            ///ISO 898-1 BEGIN
            ///

            ///LABELS------------------------
            //box1Label1 Резьба, D:
            box1Label1.Location = new System.Drawing.Point(56,32);
            box1Label1.Text = "Резьба, D:";
            box1Label1.Size = new System.Drawing.Size(64,16);
            box1Label1.TabIndex = 1;

            //box1Label2 Шаг:
            box1Label2.Location = new System.Drawing.Point (84,0);
            box1Label2.Top = box1Label1.Top + 30;
            box1Label2.Text = "Шаг:";
            box1Label2.Size = new System.Drawing.Size (36,16);
            box1Label2.TabIndex = 2;

            //box1Label3 Длина резьбы:
            box1Label3.Location = new System.Drawing.Point (30,0);
            box1Label3.Top = box1Label2.Top + 30;
            box1Label3.Text = "Длина резьбы:";
            box1Label3.Size = new System.Drawing.Size (90,16);
            box1Label3.TabIndex = 2;

            //box1Label3 Класс прочности:
            box1Label4.Location = new System.Drawing.Point (11,0);
            box1Label4.Top = box1Label3.Top + 30;
            box1Label4.Text = "Класс прочности:";
            box1Label4.Size = new System.Drawing.Size (109,16);
            box1Label4.TabIndex = 2;
            
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

            //box3Label7 Площадь поверхности резьбы, Sпов:
            box3Label7.Left = box3Label1.Left + 20;
            box3Label7.Top = box3Label5.Top + 30;
            box3Label7.Text = "Площадь поверхности резьбы:";
            box3Label7.Size = new System.Drawing.Size(180,16);
            box3Label7.TabIndex = 1;

            ///TEXTBOX------------------------
            //box1TextBox1 D
            box1TextBox1.Left = box1Label1.Left + box1Label1.Width;
            box1TextBox1.Top = box1Label1.Top - 5;
            box1TextBox1.Size = new System.Drawing.Size(70,20);
            box1TextBox1.TabIndex = 1;

            //box1ComboBox1 Step
            box1ComboBox1.Left = box1TextBox1.Left; 
            box1ComboBox1.Top = box1Label2.Top - 5;
            box1ComboBox1.Size = new System.Drawing.Size(70,20);
            box1ComboBox1.TabIndex = 2;

            //box1TextBox2 Длина резьбы
            box1TextBox2.Left = box1TextBox1.Left; 
            box1TextBox2.Top = box1Label3.Top - 5;
            box1TextBox2.Size = new System.Drawing.Size(70,20);
            box1TextBox2.TabIndex = 3;

            //box1TextBox3 Strenght
            box1TextBox3.Left = box1TextBox1.Left; 
            box1TextBox3.Top = box1Label4.Top - 5;
            box1TextBox3.Size = new System.Drawing.Size(70,20);
            box1TextBox3.TabIndex = 4;

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

            //box3TextBox4
            box3TextBox4.Left = box3TextBox1.Left;
            box3TextBox4.Top = box3Label7.Top - 5;
            box3TextBox4.Size = new System.Drawing.Size(70, 20);
            box3TextBox4.TabIndex = 8;
            
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

            //box3Label8 мм2
            box3Label8.Left = box3TextBox4.Left + box3TextBox4.Width;
            box3Label8.Top = box3Label7.Top;
            box3Label8.Text = "мм2";
            box3Label8.Size = new System.Drawing.Size(32,16);
            box3Label8.TabIndex = 1;
            
            //box1Button1 Поясняющая кнопка
            box1Button1.Top = box1Label4.Top - 5;
            box1Button1.Left = box1TextBox3.Left + box1TextBox3.Width + 5;
            box1Button1.Size = new System.Drawing.Size(30,25);
            box1Button1.Image = Image.FromFile("Quest.png");
            box1Button1.TabIndex = 4;

            //box2Button1 Кнопка расчета
            box2Button1.Left = 15;
            box2Button1.Top = box1TextBox1.Top - 5;
            box2Button1.TextAlign = ContentAlignment.MiddleCenter;
            box2Button1.Text = "Выполнить";
            box2Button1.Size = new System.Drawing.Size(295,25);
            box1Button1.TabIndex = 5;

            //CheckBox1 Мелкий шаг
            box1CheckBox1.Left = box1Label1.Left + box1Label1.Width + box1TextBox1.Width + 5;
            box1CheckBox1.Top = box1Label1.Top;
            box1CheckBox1.Text = "Мелкий шаг";
            box1CheckBox1.Size = new System.Drawing.Size(96,16);
            box1CheckBox1.TabIndex = 1;
            box1CheckBox1.Visible = true;

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

            // Adds the TabControl to the form
            this.Controls.Add(this.tabControl1);

            //Adds the tab pages to the TabControl
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);

            //add to tab1 ГОСТ ISO 898-1
            tabPage1.Controls.Add(this.groupBox1);
            tabPage1.Controls.Add(this.groupBox2);
            tabPage1.Controls.Add(this.groupBox3);

            //add to groupBox1
            groupBox1.Controls.Add(this.box1Label1);
            groupBox1.Controls.Add(this.box1Label3);
            groupBox1.Controls.Add(this.box1Label4);
            groupBox1.Controls.Add(this.box1TextBox1);

            groupBox1.Controls.Add(this.box1TextBox2);
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
            groupBox3.Controls.Add(this.box3Label7);
            groupBox3.Controls.Add(this.box3Label8);
            groupBox3.Controls.Add(this.box3TextBox1);
            groupBox3.Controls.Add(this.box3TextBox2);
            groupBox3.Controls.Add(this.box3TextBox3);
            groupBox3.Controls.Add(this.box3TextBox4);

            //Form1
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            //TabControl
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Size = new System.Drawing.Size(640,450);
            tabControl1.SelectedIndex = 0;
            tabControl1.TabIndex = 0;

            //tabPage1
            tabPage1.Text = "ГОСТ ISO 898-1";
            tabPage1.Size = new System.Drawing.Size(640, 416);
            tabPage1.TabIndex = 0;

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

            box1CheckBox1.Click += new EventHandler(box1CheckBox1_Click);
            box1Button1.Click += new EventHandler(box1Button1_Click);
            box2Button1.Click += new EventHandler(box2Button1_Click);
            box1TextBox1.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1TextBox1.Leave += new EventHandler(box1TextBox1_Leave);
            box1TextBox2.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1TextBox3.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
            box1ComboBox1.KeyPress += new KeyPressEventHandler(box1TextBox1_KeyPress);
        }

    }
      #endregion
}
