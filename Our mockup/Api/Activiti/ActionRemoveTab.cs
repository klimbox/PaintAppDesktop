using Our_mockup.Api.Tab;
using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.StatusBar;
using System;

namespace Our_mockup.Api
{
    public class ActionRemoveTab
    {
        private XCommand xCommand;
        public pDraw draw;
        public NewTab newTab;
        public MenuBarr menuBarr;
        public StatusBar statusBar;

        public ActionRemoveTab(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Button(object sender, EventArgs e)
        {
            newTab.RemoveTab(draw, menuBarr);
            newTab.SwidthTabStatusBar(statusBar, draw);
        }
    }
}