using Our_mockup.Api.Tab;
using Our_mockup.UI;
using Our_mockup.UI.MenuBar;
using Our_mockup.UI.StatusBar;
using System;

namespace Our_mockup.Api
{
    public class ActionNewTab
    {
        private XCommand xCommand;
        public NewTab newTab;
        public pDraw draw;
        public MenuBarr menuBarr;
        public StatusBar statusBat;
        public XCommand command;
        public ActionNewTab(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void button(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            newTab.NeewTab(draw, form2, menuBarr, command);
            newTab.SwidthTabStatusBar(statusBat, draw);
        }
    }
}