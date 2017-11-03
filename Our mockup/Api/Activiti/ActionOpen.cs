using Our_mockup.Api.SaveLoad;
using Our_mockup.UI.MenuBar;
using System;

namespace Our_mockup.Api
{
    public class ActionOpen
    {
        private XCommand xCommand;
        public MenuBarr menuBarr;
        public ActionOpen(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sender, EventArgs e)
        {
            if (menuBarr.yAMALToolStripMenuItem.Checked)
            {
                Yaml yaml = new Yaml();
                yaml.SetMomento();
            }
            if (menuBarr.xsmlToolStripMenuItem.Checked)
            {
                Xsml xsml = new Xsml();
                xsml.SetMomento();
            }
            if (menuBarr.jSONToolStripMenuItem.Checked)
            {
                Json json = new Json();
                json.SetMomento();
            }
        }
    }
}