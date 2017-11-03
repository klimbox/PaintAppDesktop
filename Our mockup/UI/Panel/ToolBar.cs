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

namespace Our_mockup.UI.ToolBar
{
    public partial class ToolBarr : UserControl
    {
        public ToolBarr(XCommand command)
        {
            InitializeComponent();
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.FigurType.Menu);
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.StrockeWidth.Menu);
            enterTexstToolStripMenuItem.Click += new EventHandler(command.EnterText.Button);
            colorToolStripMenuItem1.Click += new EventHandler(command.Color.Button);
            fontToolStripMenuItem.Click += new EventHandler(command.Font.Button);
            renameCurrentTabToolStripMenuItem.Click += new EventHandler(command.RenameTab.button);
            toolStripButton3.Click += new EventHandler(command.NewTab.button);
            removeToolStripMenuItem.Click += new EventHandler(command.RemoveTab.Button);
            toolStripButton1.Click += new EventHandler(command.Save.Menu);
            toolStripButton2.Click += new EventHandler(command.Open.Menu);
        }
    }
}
