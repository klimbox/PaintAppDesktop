using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Our_mockup.Api;

namespace Our_mockup.UI
{
    public partial class pDraw : UserControl
    {
        public pDraw(XCommand command)
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += new EventHandler(command.swithTab.SwithTabStatusMenuBar);
            MouseMove += new MouseEventHandler(command.Mouse.MouseMove);
        }
    }
}
