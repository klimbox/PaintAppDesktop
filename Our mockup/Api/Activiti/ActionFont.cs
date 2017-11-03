using System;
using System.Windows.Forms;

namespace Our_mockup.Api
{
    public class ActionFont
    {
        private XCommand xCommand;

        public ActionFont(XCommand xCommand)
        {
            this.xCommand = xCommand;
        }
        public void Button(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                xCommand.data.FontText = fontDialog.Font;
            }
        }
    }
}