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

namespace Our_mockup.UI.MenuBar
{
    public partial class MenuBarr : UserControl
    {

        public MenuBarr(XCommand command)
        {
            InitializeComponent();
            typeleToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.FigurType.Menu);
            colortToolStripMenuItem.Click += new EventHandler(command.Color.Button);
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.StrockeWidth.Menu);
            enterTextToolStripMenuItem.Click += new EventHandler(command.EnterText.Button);
            colorToolStripMenuItem.Click += new EventHandler(command.Color.Buttonn);
            fontToolStripMenuItem.Click += new EventHandler(command.Font.Button);
            newTabToolStripMenuItem.Click += new EventHandler(command.NewTab.button);
            renameCurentTabToolStripMenuItem.Click += new EventHandler(command.RenameTab.button);
            aboutTheProgramToolStripMenuItem.Click += new EventHandler(command.Help.Button);
            removeToolStripMenuItem.Click += new EventHandler(command.RemoveTab.Button);
            saveToolStripMenuItem.Click += new EventHandler(command.Save.Menu);
            opemToolStripMenuItem.Click += new EventHandler(command.Open.Menu);
            switchTabToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.swithTab.SwithTabStatusMenuBar);
            languageToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.Language.Menu);
            chooseThemeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(command.Theme.Menu);
        }
        private void yAMALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yAMALToolStripMenuItem.Checked = true;
            jSONToolStripMenuItem.Checked = false;
            xsmlToolStripMenuItem.Checked = false;
        }

        private void xsmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xsmlToolStripMenuItem.Checked = true;
            yAMALToolStripMenuItem.Checked = false;
            jSONToolStripMenuItem.Checked = false;
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jSONToolStripMenuItem.Checked = true;
            xsmlToolStripMenuItem.Checked = false;
            yAMALToolStripMenuItem.Checked = false;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = true;
            russianToolStripMenuItem.Checked = false;
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            russianToolStripMenuItem.Checked = true;
        }
    }
}
