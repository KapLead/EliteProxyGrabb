using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EliteProxyGrabb
{
    public partial class ProxyList : UserControl
    {
        public ThreadBindingList<Proxy> Items { get; private set; }
        public object DataSource
        {
            get => listBox1.DataSource;
            set
            {
                listBox1.DataSource = null;
                listBox1.DataSource = value;
            }
        }

        public ProxyList()
        {
            InitializeComponent();
            Items = new ThreadBindingList<Proxy>();
            listBox1.DataSource = Items;
        }

        public bool Contains(Proxy proxy)
        {
            return Items.FirstOrDefault(f => f.Ip == proxy.Ip && f.Port == proxy.Port) != null;
        }

        private StringFormat left = new StringFormat
            { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
        private StringFormat centr = new StringFormat
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
                    e.Index, e.State ^ DrawItemState.Selected,
                    e.ForeColor,Color.FromArgb(90,90,90));
            e.DrawBackground();
            Proxy p = listBox1.Items[e.Index] as Proxy;
            if(p==null) return;
            e.Graphics.DrawString(p.Ip, listBox1.Font, new SolidBrush(e.ForeColor),
                new RectangleF(lip.Left, e.Bounds.Y, lip.Width, e.Bounds.Height), left);
            e.Graphics.DrawString(p.Port, listBox1.Font, new SolidBrush(e.ForeColor),
                new RectangleF(lport.Left, e.Bounds.Y, lport.Width, e.Bounds.Height), centr);
            if(p.Country!=null)
            {
                e.Graphics.DrawString(p.Country, listBox1.Font, new SolidBrush(e.ForeColor),
                new RectangleF(lcountry.Left, e.Bounds.Y, lcountry.Width, e.Bounds.Height), left);

            }

            if (string.IsNullOrWhiteSpace(p.Level)) p.Level = " ";
            e.Graphics.DrawString($"{p.LastCheckData} | {p.Level.Substring(0,p.Level.IndexOf(" "))}",
                listBox1.Font, new SolidBrush(e.ForeColor),
                new RectangleF(llevel.Left, e.Bounds.Y, llevel.Width, e.Bounds.Height), centr); ;
            e.Graphics.DrawString($"{p.Protocol}", listBox1.Font, new SolidBrush(Color.DarkOrange),
                new RectangleF(lhostname.Left, e.Bounds.Y, lhostname.Width, e.Bounds.Height), left);
            e.Graphics.DrawString($"[ {p.Number} ]", listBox1.Font, new SolidBrush(e.ForeColor),
                new RectangleF(lhostname.Left+40, e.Bounds.Y, lhostname.Width-40, e.Bounds.Height), left);
            e.Graphics.DrawString($"{p.HostName}", listBox1.Font, new SolidBrush(Color.BurlyWood),
                new RectangleF(lhostname.Left + 70, e.Bounds.Y, lhostname.Width - 70, e.Bounds.Height), left);
            //e.Graphics.DrawLine(Pens.DarkGray,0,e.Bounds.Bottom,e.Bounds.Width,e.Bounds.Height);
        }
    }
}
