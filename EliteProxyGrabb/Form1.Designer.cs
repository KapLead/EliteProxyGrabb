
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
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings1.Location = new System.Drawing.Point(11, 64);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(684, 330);
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
    }
}

