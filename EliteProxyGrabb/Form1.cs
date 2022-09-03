using System;
using System.Drawing;
using System.Windows.Forms;

namespace EliteProxyGrabb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectTab(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                pAccept.Location = new Point(btn.Left, 0);
                pAccept.Size = new Size(btn.Width, pAccept.Height);
                var num = int.Parse(btn.Tag.ToString());
                if (num == 0)
                {
                    proxyList1.Dock = DockStyle.Fill;
                    proxyList1.BringToFront();
                    proxyCompliteList1.Dock = DockStyle.None;
                    proxyCompliteList1.SendToBack();
                }
            }
        }
    }
}
