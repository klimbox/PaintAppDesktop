using Our_mockup.Api.Tab;
using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.StatusBar;
using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionSwithTab
    {
        private XCommand xCommand;
        public NewTab newTab;
        public pDraw draw;
        public UI.StatusBar.StatusBar statusBar;
        public ActionSwithTab(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void SwithTabStatusMenuBar(object sender, ToolStripItemClickedEventArgs e)
        {
            newTab.SwithTabstatusMenuBarr(draw, e);
            newTab.SwidthTabStatusBar(statusBar, draw);
        }
        public void SwithTabStatusMenuBar(object sender, EventArgs e)
        {
            newTab.SwidthTabStatusBar(statusBar, draw);
        }
    }
}