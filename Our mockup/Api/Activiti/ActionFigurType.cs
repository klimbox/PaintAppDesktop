using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionFigurType
    {
        private XCommand xCommand;

        public ActionFigurType(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sender, ToolStripItemClickedEventArgs e)
        {
            xCommand.data.FigureType = e.ClickedItem.Text;
        }
        public void Button(object sender, EventArgs e)
        {
            xCommand.data.FigureType = ((Button)sender).Text.ToString();
        }
    }
}