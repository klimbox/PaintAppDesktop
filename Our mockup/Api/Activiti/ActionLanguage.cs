using Our_mockup.Api.Language;
using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionLanguage
    {
        private XCommand xCommand;
        public SetapLanuage setapLanuage;
        public ActionLanguage(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sender, ToolStripItemClickedEventArgs e)
        {
            string str = e.ClickedItem.Text;
            switch(str)
            {
                case "English":
                    {
                        setapLanuage.SetapEnglish();
                        break;
                    }
                case "Русский":
                    {
                        setapLanuage.SetapRussian();
                        break;
                    }
            }
        }
    }
}