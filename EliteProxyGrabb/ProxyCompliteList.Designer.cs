
namespace EliteProxyGrabb
{
    partial class ProxyCompliteList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lhostname = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.llevel = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.lcountry = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lport = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(598, 378);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lhostname);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.llevel);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.lcountry);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.lport);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.lip);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 26);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(597, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 25);
            this.panel3.TabIndex = 10;
            // 
            // lhostname
            // 
            this.lhostname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lhostname.Location = new System.Drawing.Point(384, 1);
            this.lhostname.Name = "lhostname";
            this.lhostname.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lhostname.Size = new System.Drawing.Size(214, 25);
            this.lhostname.TabIndex = 8;
            this.lhostname.Text = "HOST NAME";
            this.lhostname.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.Color.Gray;
            this.splitter4.Location = new System.Drawing.Point(383, 1);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1, 25);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // llevel
            // 
            this.llevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.llevel.Location = new System.Drawing.Point(272, 1);
            this.llevel.Name = "llevel";
            this.llevel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.llevel.Size = new System.Drawing.Size(111, 25);
            this.llevel.TabIndex = 6;
            this.llevel.Text = "LEVEL";
            this.llevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Gray;
            this.splitter3.Location = new System.Drawing.Point(271, 1);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1, 25);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // lcountry
            // 
            this.lcountry.Dock = System.Windows.Forms.DockStyle.Left;
            this.lcountry.Location = new System.Drawing.Point(205, 1);
            this.lcountry.Name = "lcountry";
            this.lcountry.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lcountry.Size = new System.Drawing.Size(66, 25);
            this.lcountry.TabIndex = 4;
            this.lcountry.Text = "COUNTRY";
            this.lcountry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Gray;
            this.splitter2.Location = new System.Drawing.Point(204, 1);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 25);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // lport
            // 
            this.lport.Dock = System.Windows.Forms.DockStyle.Left;
            this.lport.Location = new System.Drawing.Point(132, 1);
            this.lport.Name = "lport";
            this.lport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lport.Size = new System.Drawing.Size(72, 25);
            this.lport.TabIndex = 2;
            this.lport.Text = "PORT";
            this.lport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gray;
            this.splitter1.Location = new System.Drawing.Point(131, 1);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 25);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lip
            // 
            this.lip.Dock = System.Windows.Forms.DockStyle.Left;
            this.lip.Location = new System.Drawing.Point(1, 1);
            this.lip.Name = "lip";
            this.lip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lip.Size = new System.Drawing.Size(130, 25);
            this.lip.TabIndex = 0;
            this.lip.Text = "IP";
            this.lip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 26);
            this.panel4.TabIndex = 11;
            // 
            // ProxyCompliteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ProxyCompliteList";
            this.Size = new System.Drawing.Size(598, 404);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lip;
        private System.Windows.Forms.Label lhostname;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label llevel;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label lcountry;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label lport;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
