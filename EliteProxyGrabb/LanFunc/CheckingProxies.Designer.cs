
namespace EliteProxyGrabb.LanFunc
{
    partial class CheckingProxies
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerCheckActuality = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lnew = new System.Windows.Forms.Label();
            this.lall = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerCheckActuality
            // 
            this.timerCheckActuality.Enabled = true;
            this.timerCheckActuality.Interval = 3500;
            this.timerCheckActuality.Tick += new System.EventHandler(this.timerCheckActuality_Tick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новых на проверке";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnew
            // 
            this.lnew.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnew.Location = new System.Drawing.Point(108, 0);
            this.lnew.Name = "lnew";
            this.lnew.Size = new System.Drawing.Size(63, 22);
            this.lnew.TabIndex = 1;
            this.lnew.Text = "0";
            this.lnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lall
            // 
            this.lall.Dock = System.Windows.Forms.DockStyle.Left;
            this.lall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lall.Location = new System.Drawing.Point(273, 0);
            this.lall.Name = "lall";
            this.lall.Size = new System.Drawing.Size(63, 22);
            this.lall.TabIndex = 3;
            this.lall.Text = "0";
            this.lall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Проверено всего";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckingProxies
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnew);
            this.Controls.Add(this.label1);
            this.Name = "CheckingProxies";
            this.Size = new System.Drawing.Size(365, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerCheckActuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnew;
        private System.Windows.Forms.Label lall;
        private System.Windows.Forms.Label label4;
    }
}
