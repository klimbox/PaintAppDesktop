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

namespace Our_mockup.UI.Panel
{
    public partial class Figuree : UserControl
    { 
        public Figuree(XCommand xCommand)
        {
            InitializeComponent();
            MouseDown += new MouseEventHandler(xCommand.FigurMouse.figurDown);
            MouseMove += new MouseEventHandler(xCommand.FigurMouse.move);
            Width = 0; Height = 0;
        }

        private void Figuree_MouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void Figuree_MouseLeave(object sender, EventArgs e)
        {
            if (Focused == false)
            {
                BorderStyle = BorderStyle.None;
            }
        }
    }
}
