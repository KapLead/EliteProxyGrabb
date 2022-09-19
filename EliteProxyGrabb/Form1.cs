using EliteProxyGrabb.LanFunc;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
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
            Initialize();
        }

        private void Initialize()
        {
            if(!File.Exists("recovery")) return;
            var f = File.ReadAllText("recovery", Encoding.UTF8).Split('\n');
            foreach (string s in f[0].Split('|'))
            {
                if(string.IsNullOrWhiteSpace(s)) continue;
                string[] d = s.Split('\t');
                if(d.Length!=3) continue;
                try{checkingProxies1.NewProxy.Add(new Proxy{Ip = d[0], Port = d[1], Protocol = d[2] }); } catch { }
            }
            foreach (string s in f[1].Split('|'))
            {
                if (string.IsNullOrWhiteSpace(s)) continue;
                string[] d = s.Split('\t');
                if (d.Length != 7) continue;
                try{checkingProxies1.Working.Add(new Proxy{Ip = d[0],Port = d[1], Protocol = d[2],Country = d[3], Level = d[4], HostName = d[5], LastCheckData = d[6]});}catch { }
            }
            foreach (string s in f[2].Split('|'))
            {
                if (string.IsNullOrWhiteSpace(s)) continue;
                string[] d = s.Split('\t');
                if (d.Length != 2) continue;
                try{checkingProxies1.BadProxy.Add(new Proxy { Ip = d[0], Port = d[1] });}catch { }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            string f = null;
            foreach (Proxy p in checkingProxies1.NewProxy)
                f += $"{p.Ip}\t{p.Port}\t{p.Protocol}|";
            f += "\n";
            foreach (Proxy p in checkingProxies1.Working)
                f += $"{p.Ip}\t{p.Port}\t{p.Protocol}\t{p.Country}\t{p.Level}\t{p.HostName}\t{p.LastCheckData}|";
            f += "\n";
            foreach (Proxy p in checkingProxies1.BadProxy)
                f += $"{p.Ip}\t{p.Port}|";
            File.WriteAllText("recovery",f, Encoding.UTF8);
        }

        private void CheckingProxies1OnChecked(object sender, EventArgs e)
        {
            lCount.Text = checkingProxies1.Working.Count.ToString();
        }

        private void OnShown(object sender, EventArgs e)
        {
            checkingProxies1.Add(new FreeProxyList { NextCheck = 80 });
            checkingProxies1.Add(new AdvancedName { NextCheck = 80 });
            checkingProxies1.Add(new HidemyName { NextCheck = 60 });
            checkingProxies1.Add(new SpysOne { NextCheck = 90 });
            checkingProxies1.Add(new FreeProxyUpdate { NextCheck = 50 });
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
