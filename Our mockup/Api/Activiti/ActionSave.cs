using Our_mockup.Api.SaveLoad;
using Our_mockup.UI.MenuBar;
using System;

namespace Our_mockup.Api
{
    public class ActionSave
    {

        private XCommand xCommand;
        public MenuBarr menuBarr;
        public ActionSave(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sende, EventArgs e)
        {
            if(menuBarr.yAMALToolStripMenuItem.Checked)
            {
                Yaml yaml = new Yaml();
                yaml.GetMomento();
            }
            if (menuBarr.xsmlToolStripMenuItem.Checked)
            {
                Xsml xsml = new Xsml();
                xsml.GetMomento();
            }
            if (menuBarr.jSONToolStripMenuItem.Checked)
            {
                Json json = new Json();
                json.GetMomento();
            }
        }
    }
}