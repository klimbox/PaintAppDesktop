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

namespace Our_mockup.UI.ContexMeny
{
    public partial class ContexMenu : UserControl
    {
        public ContexMenu(XCommand command)
        {
            InitializeComponent();
            figureTypeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.FigurType.Menu);
        }
    }
}
