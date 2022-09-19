using EliteProxyGrabb.LanFunc;
using System;
using System.IO;
using System.Windows.Forms;

namespace EliteProxyGrabb
{
    public partial class Settings : UserControl
    {
        public CheckingProxies Checking { get; set; }
        public ProxyCompliteList Checking2 { get; set; }
        public Settings()
        {
            InitializeComponent();
        }

        public void SaveNew() => button4_Click(this, null);
        private void button4_Click(object sender, EventArgs e)
        {
            if (Checking != null)
                foreach (Proxy p in Checking.NewProxy)
                {
                    File.AppendAllText("newproxy.txt",
                        $"{(c11.Checked ? p.Ip : "")}\t" +
                        $"{(c12.Checked ? ":" + p.Port : "")}\t" +
                        $"{(c13.Checked ? "\t" + p.Protocol : "")}\t" +
                        $"{(c14.Checked ? "\t" + p.Country : "")}\t" +
                        $"{(c15.Checked ? "\t" + p.Level : "")}\r\n"
                            .Replace("\t\t", "\t").Replace("\t\t", "\t").Replace("\t\t", "\t"));
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Checking != null)
                foreach (Proxy p in Checking.Working)
                {
                    File.AppendAllText("okproxy.txt",
                        $"{(c21.Checked ? p.Ip : "")}\t" +
                        $"{(c22.Checked ? ":" + p.Port : "")}\t" +
                        $"{(c23.Checked ? "\t" + p.Protocol : "")}\t" +
                        $"{(c24.Checked ? "\t" + p.Country : "")}\t" +
                        $"{(c25.Checked ? "\t" + p.Level : "")}\r\n"
                            .Replace("\t\t", "\t").Replace("\t\t", "\t").Replace("\t\t", "\t"));
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Checking2 != null)
                foreach (Proxy p in Checking2.Items)
                {
                    File.AppendAllText("compliteproxy.txt",
                        $"{(c31.Checked ? p.Ip : "")}\t" +
                        $"{(c32.Checked ? ":" + p.Port : "")}\t" +
                        $"{(c33.Checked ? "\t" + p.Protocol : "")}\t" +
                        $"{(c34.Checked ? "\t" + p.Country : "")}\t" +
                        $"{(c35.Checked ? "\t" + p.Level : "")}\r\n"
                            .Replace("\t\t", "\t").Replace("\t\t", "\t").Replace("\t\t", "\t"));
                }
        }

    }
}
