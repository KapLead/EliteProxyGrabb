using System.Windows.Forms;

namespace EliteProxyGrabb
{
    public partial class ProxyList : UserControl
    {
        public ProxyList()
        {
            InitializeComponent();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds,
                    e.Index, e.State ^ DrawItemState.Selected,
                    e.ForeColor, Properties.Settings.Default.SelectBackItem);
            e.DrawBackground();

        }
    }
}
