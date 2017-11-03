using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionStrockeWidth
    {
        private XCommand xCommand;

        public ActionStrockeWidth(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Menu(object sender, ToolStripItemClickedEventArgs e)
        {
            xCommand.data.StrockeWidth = Convert.ToInt32(e.ClickedItem.Text);
        }
        public void ComboBox(object sender, EventArgs e)
        {
            xCommand.data.StrockeWidth = Convert.ToInt32(((ComboBox)sender).SelectedText);
        }
    }
}