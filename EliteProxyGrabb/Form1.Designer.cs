
namespace EliteProxyGrabb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pAccept = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.c11 = new System.Windows.Forms.CheckBox();
            this.c12 = new System.Windows.Forms.CheckBox();
            this.c13 = new System.Windows.Forms.CheckBox();
            this.c14 = new System.Windows.Forms.CheckBox();
            this.c15 = new System.Windows.Forms.CheckBox();
            this.c25 = new System.Windows.Forms.CheckBox();
            this.c24 = new System.Windows.Forms.CheckBox();
            this.c23 = new System.Windows.Forms.CheckBox();
            this.c22 = new System.Windows.Forms.CheckBox();
            this.c21 = new System.Windows.Forms.CheckBox();
            this.c35 = new System.Windows.Forms.CheckBox();
            this.c34 = new System.Windows.Forms.CheckBox();
            this.c33 = new System.Windows.Forms.CheckBox();
            this.c32 = new System.Windows.Forms.CheckBox();
            this.c31 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.settings1 = new EliteProxyGrabb.Settings();
            this.proxyCompliteList1 = new EliteProxyGrabb.ProxyCompliteList();
            this.proxyList1 = new EliteProxyGrabb.ProxyList();
            this.checkingProxies1 = new EliteProxyGrabb.LanFunc.CheckingProxies();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pAccept);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 30);
            this.panel1.TabIndex = 2;
            // 
            // pAccept
            // 
            this.pAccept.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pAccept.Location = new System.Drawing.Point(0, 0);
            this.pAccept.Name = "pAccept";
            this.pAccept.Size = new System.Drawing.Size(206, 4);
            this.pAccept.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::EliteProxyGrabb.Properties.Resources.setting_tools;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(393, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(120, 30);
            this.button3.TabIndex = 3;
            this.button3.Tag = "2";
            this.button3.Text = "НАСТРОЙКИ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SelectTab);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::EliteProxyGrabb.Properties.Resources.check_box_mix;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(204, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 30);
            this.button2.TabIndex = 2;
            this.button2.Tag = "1";
            this.button2.Text = "ИСПОЛЬЗОВАННЫЕ ПРОКСИ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SelectTab);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EliteProxyGrabb.Properties.Resources.check_box;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 1;
            this.button1.Tag = "0";
            this.button1.Text = "СПИСОК ДОСТУПНЫХ ПРОКСИ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SelectTab);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.c35);
            this.panel2.Controls.Add(this.c34);
            this.panel2.Controls.Add(this.c33);
            this.panel2.Controls.Add(this.c32);
            this.panel2.Controls.Add(this.c31);
            this.panel2.Controls.Add(this.c25);
            this.panel2.Controls.Add(this.c24);
            this.panel2.Controls.Add(this.c23);
            this.panel2.Controls.Add(this.c22);
            this.panel2.Controls.Add(this.c21);
            this.panel2.Controls.Add(this.c15);
            this.panel2.Controls.Add(this.c14);
            this.panel2.Controls.Add(this.c13);
            this.panel2.Controls.Add(this.c12);
            this.panel2.Controls.Add(this.c11);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.settings1);
            this.panel2.Controls.Add(this.proxyCompliteList1);
            this.panel2.Controls.Add(this.proxyList1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 391);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkingProxies1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 23);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(644, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "KapLead";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.Community);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EliteProxyGrabb.Properties.Resources.tg3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(619, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Community);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 206);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(203, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить не проверенные";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(10, 181);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 4, 0, 0);
            this.label2.Size = new System.Drawing.Size(483, 113);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сохраняемые параменты                           IP            Порт       Протокол" +
    "    Страна     Уровень      ";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 235);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(203, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сохранить проверенные";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(11, 264);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(203, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Сохранить выданные";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // c11
            // 
            this.c11.AutoSize = true;
            this.c11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c11.Checked = true;
            this.c11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c11.Location = new System.Drawing.Point(233, 214);
            this.c11.Name = "c11";
            this.c11.Size = new System.Drawing.Size(15, 14);
            this.c11.TabIndex = 7;
            this.c11.UseVisualStyleBackColor = false;
            // 
            // c12
            // 
            this.c12.AutoSize = true;
            this.c12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c12.Checked = true;
            this.c12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c12.Location = new System.Drawing.Point(287, 214);
            this.c12.Name = "c12";
            this.c12.Size = new System.Drawing.Size(15, 14);
            this.c12.TabIndex = 8;
            this.c12.UseVisualStyleBackColor = false;
            // 
            // c13
            // 
            this.c13.AutoSize = true;
            this.c13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c13.Location = new System.Drawing.Point(340, 214);
            this.c13.Name = "c13";
            this.c13.Size = new System.Drawing.Size(15, 14);
            this.c13.TabIndex = 9;
            this.c13.UseVisualStyleBackColor = false;
            // 
            // c14
            // 
            this.c14.AutoSize = true;
            this.c14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c14.Location = new System.Drawing.Point(395, 214);
            this.c14.Name = "c14";
            this.c14.Size = new System.Drawing.Size(15, 14);
            this.c14.TabIndex = 10;
            this.c14.UseVisualStyleBackColor = false;
            // 
            // c15
            // 
            this.c15.AutoSize = true;
            this.c15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c15.Location = new System.Drawing.Point(454, 214);
            this.c15.Name = "c15";
            this.c15.Size = new System.Drawing.Size(15, 14);
            this.c15.TabIndex = 11;
            this.c15.UseVisualStyleBackColor = false;
            // 
            // c25
            // 
            this.c25.AutoSize = true;
            this.c25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c25.Location = new System.Drawing.Point(454, 243);
            this.c25.Name = "c25";
            this.c25.Size = new System.Drawing.Size(15, 14);
            this.c25.TabIndex = 16;
            this.c25.UseVisualStyleBackColor = false;
            // 
            // c24
            // 
            this.c24.AutoSize = true;
            this.c24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c24.Location = new System.Drawing.Point(395, 243);
            this.c24.Name = "c24";
            this.c24.Size = new System.Drawing.Size(15, 14);
            this.c24.TabIndex = 15;
            this.c24.UseVisualStyleBackColor = false;
            // 
            // c23
            // 
            this.c23.AutoSize = true;
            this.c23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c23.Location = new System.Drawing.Point(340, 243);
            this.c23.Name = "c23";
            this.c23.Size = new System.Drawing.Size(15, 14);
            this.c23.TabIndex = 14;
            this.c23.UseVisualStyleBackColor = false;
            // 
            // c22
            // 
            this.c22.AutoSize = true;
            this.c22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c22.Checked = true;
            this.c22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c22.Location = new System.Drawing.Point(287, 243);
            this.c22.Name = "c22";
            this.c22.Size = new System.Drawing.Size(15, 14);
            this.c22.TabIndex = 13;
            this.c22.UseVisualStyleBackColor = false;
            // 
            // c21
            // 
            this.c21.AutoSize = true;
            this.c21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c21.Checked = true;
            this.c21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c21.Location = new System.Drawing.Point(233, 243);
            this.c21.Name = "c21";
            this.c21.Size = new System.Drawing.Size(15, 14);
            this.c21.TabIndex = 12;
            this.c21.UseVisualStyleBackColor = false;
            // 
            // c35
            // 
            this.c35.AutoSize = true;
            this.c35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c35.Location = new System.Drawing.Point(454, 272);
            this.c35.Name = "c35";
            this.c35.Size = new System.Drawing.Size(15, 14);
            this.c35.TabIndex = 21;
            this.c35.UseVisualStyleBackColor = false;
            // 
            // c34
            // 
            this.c34.AutoSize = true;
            this.c34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c34.Location = new System.Drawing.Point(395, 272);
            this.c34.Name = "c34";
            this.c34.Size = new System.Drawing.Size(15, 14);
            this.c34.TabIndex = 20;
            this.c34.UseVisualStyleBackColor = false;
            // 
            // c33
            // 
            this.c33.AutoSize = true;
            this.c33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c33.Location = new System.Drawing.Point(340, 272);
            this.c33.Name = "c33";
            this.c33.Size = new System.Drawing.Size(15, 14);
            this.c33.TabIndex = 19;
            this.c33.UseVisualStyleBackColor = false;
            // 
            // c32
            // 
            this.c32.AutoSize = true;
            this.c32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c32.Checked = true;
            this.c32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c32.Location = new System.Drawing.Point(287, 272);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(15, 14);
            this.c32.TabIndex = 18;
            this.c32.UseVisualStyleBackColor = false;
            // 
            // c31
            // 
            this.c31.AutoSize = true;
            this.c31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.c31.Checked = true;
            this.c31.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c31.Location = new System.Drawing.Point(233, 272);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(15, 14);
            this.c31.TabIndex = 17;
            this.c31.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(213, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 113);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(265, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 113);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(319, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 113);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(377, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 113);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(433, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 113);
            this.panel8.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(10, 206);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(483, 3);
            this.panel9.TabIndex = 27;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(10, 234);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(483, 3);
            this.panel10.TabIndex = 28;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gray;
            this.panel11.Location = new System.Drawing.Point(10, 263);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(483, 3);
            this.panel11.TabIndex = 29;
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings1.Location = new System.Drawing.Point(-3, 126);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(698, 268);
            this.settings1.TabIndex = 2;
            // 
            // proxyCompliteList1
            // 
            this.proxyCompliteList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.proxyCompliteList1.Location = new System.Drawing.Point(0, 3);
            this.proxyCompliteList1.Name = "proxyCompliteList1";
            this.proxyCompliteList1.Size = new System.Drawing.Size(698, 55);
            this.proxyCompliteList1.TabIndex = 1;
            // 
            // proxyList1
            // 
            this.proxyList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proxyList1.Location = new System.Drawing.Point(0, 3);
            this.proxyList1.Name = "proxyList1";
            this.proxyList1.Size = new System.Drawing.Size(698, 50);
            this.proxyList1.TabIndex = 0;
            // 
            // checkingProxies1
            // 
            this.checkingProxies1.BackColor = System.Drawing.Color.Transparent;
            this.checkingProxies1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkingProxies1.Location = new System.Drawing.Point(0, 0);
            this.checkingProxies1.Name = "checkingProxies1";
            this.checkingProxies1.ProxyCompliteList = null;
            this.checkingProxies1.ProxyList = null;
            this.checkingProxies1.Size = new System.Drawing.Size(451, 23);
            this.checkingProxies1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ELITE PROXY GRABBER ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pAccept;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Settings settings1;
        private ProxyCompliteList proxyCompliteList1;
        private ProxyList proxyList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LanFunc.CheckingProxies checkingProxies1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox c35;
        private System.Windows.Forms.CheckBox c34;
        private System.Windows.Forms.CheckBox c33;
        private System.Windows.Forms.CheckBox c32;
        private System.Windows.Forms.CheckBox c31;
        private System.Windows.Forms.CheckBox c25;
        private System.Windows.Forms.CheckBox c24;
        private System.Windows.Forms.CheckBox c23;
        private System.Windows.Forms.CheckBox c22;
        private System.Windows.Forms.CheckBox c21;
        private System.Windows.Forms.CheckBox c15;
        private System.Windows.Forms.CheckBox c14;
        private System.Windows.Forms.CheckBox c13;
        private System.Windows.Forms.CheckBox c12;
        private System.Windows.Forms.CheckBox c11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

