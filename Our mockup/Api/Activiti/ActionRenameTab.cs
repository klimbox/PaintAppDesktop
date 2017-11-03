using Our_mockup.Api.Tab;
using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.StatusBar;
using System;

namespace Our_mockup.Api
{
    public class ActionRenameTab
    {
        private XCommand xCommand;
        public pDraw draw;
        public NewTab newTab;
        public MenuBarr menuBarr;
        public StatusBar statusBar;

        public ActionRenameTab(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void button(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            newTab.RenameTab(draw, form2, menuBarr);
            newTab.SwidthTabStatusBar(statusBar, draw);
        }
    }
}