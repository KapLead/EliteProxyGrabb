using EliteProxyGrabb.LanFunc;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EliteProxyGrabb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += OnLoad;
            Shown += OnShown;
            checkingProxies1.SetInterval(1000, 100);
            checkingProxies1.Checked += CheckingProxies1OnChecked;
            proxyList1.DataSource = checkingProxies1.Working;
        }

        private void CheckingProxies1OnChecked(object sender, EventArgs e)
        {
            lCount.Text = checkingProxies1.Working.Count.ToString();
        }

        private void OnShown(object sender, EventArgs e)
        {
            checkingProxies1.Add(new HidemyName { NextCheck = 60 });
            checkingProxies1.Add(new SpysOne { NextCheck = 90 });
            checkingProxies1.Add(new FreeProxyUpdate { NextCheck = 30 });
        }

        private void OnLoad(object sender, EventArgs e)
        {
            SelectTab(button3, e);
        }

        private void SelectTab(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                pAccept.Location = new Point(btn.Left, 0);
                pAccept.Size = new Size(btn.Width, pAccept.Height);
                var num = int.Parse(btn.Tag.ToString());
                proxyList1.Dock = num == 0 ? DockStyle.Fill : DockStyle.None;
                proxyCompliteList1.Dock = num == 1 ? DockStyle.Fill : DockStyle.None;
                settings1.Dock = num == 2 ? DockStyle.Fill : DockStyle.None;

                if (num == 0) proxyList1.BringToFront();
                else proxyList1.SendToBack();

                if (num == 1) proxyCompliteList1.BringToFront();
                else proxyCompliteList1.SendToBack();

                if (num == 2) settings1.BringToFront();
                else settings1.SendToBack();

            }
        }

        private void Community(object sender, EventArgs e)
        {
            Process.Start("https://t.me/sharphelp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
