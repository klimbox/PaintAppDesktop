using Our_mockup.Api.Theme;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionTheme
    {
        private XCommand xCommand;
        public SetapTheme setapTheme;
        public ActionTheme(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sender, ToolStripItemClickedEventArgs e)
        {
            string menu = e.ClickedItem.Name;
            switch(menu)
            {
                case "lightToolStripMenuItem":
                    {
                        setapTheme.SetapLight();
                        break;
                    }
                case "darkToolStripMenuItem":
                    {
                        setapTheme.SetapDark();
                        break;
                    }
            }
        }
    }
}