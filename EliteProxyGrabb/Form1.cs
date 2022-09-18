using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EliteProxyGrabb.LanFunc;

namespace EliteProxyGrabb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load+= OnLoad;
            Shown+= OnShown;
            checkingProxies1.SetInterval(1000,100);
            proxyList1.DataSource = checkingProxies1.Working;
            // checkingProxies1.Check(new Proxy(){Ip= "195.221.251.200", Port="8080", Protocol = "http"});
        }

        private void OnShown(object sender, EventArgs e)
        {
            checkingProxies1.Add(new FreeProxyUpdate());
        }

        private void OnLoad(object sender, EventArgs e)
        {
            SelectTab(button3,e);
        }

        private void SelectTab(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                pAccept.Location = new Point(btn.Left, 0);
                pAccept.Size = new Size(btn.Width, pAccept.Height);
                var num = int.Parse(btn.Tag.ToString());
                proxyList1.Dock = num==0? DockStyle.Fill:DockStyle.None;
                proxyCompliteList1.Dock = num==1? DockStyle.Fill: DockStyle.None;
                settings1.Dock = num==2? DockStyle.Fill: DockStyle.None;
                
                if (num == 0) proxyList1.BringToFront();
                else proxyList1.SendToBack();
                
                if (num == 1)proxyCompliteList1.BringToFront();
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

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Proxy p in checkingProxies1.NewProxy)
            {
                File.AppendAllText("newproxy.txt",
                    $"{(c11.Checked?p.Ip:"")}\t" +
                    $"{(c12.Checked?":"+p.Port:"")}\t" +
                    $"{(c13.Checked ? "\t" + p.Protocol : "")}\t" +
                    $"{(c14.Checked ? "\t" + p.Country : "")}\t" +
                    $"{(c15.Checked ? "\t" + p.Level : "")}\t");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Proxy p in checkingProxies1.Working)
            {
                File.AppendAllText("okproxy.txt",
                    $"{(c21.Checked ? p.Ip : "")}\t" +
                    $"{(c22.Checked ? ":" + p.Port : "")}\t" +
                    $"{(c23.Checked ? "\t" + p.Protocol : "")}\t" +
                    $"{(c24.Checked ? "\t" + p.Country : "")}\t" +
                    $"{(c25.Checked ? "\t" + p.Level : "")}\t");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Proxy p in proxyCompliteList1.Items)
            {
                File.AppendAllText("compliteproxy.txt",
                    $"{(c21.Checked ? p.Ip : "")}\t" +
                    $"{(c22.Checked ? ":" + p.Port : "")}\t" +
                    $"{(c23.Checked ? "\t" + p.Protocol : "")}\t" +
                    $"{(c24.Checked ? "\t" + p.Country : "")}\t" +
                    $"{(c25.Checked ? "\t" + p.Level : "")}\t");
            }
        }
    }
}
