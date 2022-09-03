using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                pAccept.Location = new Point(btn.Left,0);
                pAccept.Size = new Size(btn.Width,pAccept.Height);
            }
        }
    }
}
