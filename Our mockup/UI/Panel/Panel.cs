using System.Windows.Forms;
using Our_mockup.Api;
using Our_mockup.UI.Propertes.Propertes_Emty_figure;

namespace Our_mockup.UI.Panel
{
    public partial class Panel : UserControl
    {
        public Control control { get; set; }
        XCommand command;
        public Panel(XCommand command)
        {
            this.command = command;
            InitializeComponent();
            pDraw1.Dock = DockStyle.Fill;
        }
        public void ClearControl()
        {
            Controls.Remove(control);
        }
    }
}
